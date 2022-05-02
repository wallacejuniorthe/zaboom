namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebApi.Authorization;
using WebApi.Entities;
using WebApi.Entities.Core;
using WebApi.Helpers;
using WebApi.Models.Accounts;

public class CouponService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    private readonly AppSettings _appSettings;
    private readonly IEmailService _emailService;

    public CouponService(
        DataContext context,
        IMapper mapper,
        IOptions<AppSettings> appSettings,
        IEmailService emailService)
    {
        _context = context;
        _mapper = mapper;
        _appSettings = appSettings.Value;
        _emailService = emailService;
    }

    public AvailableCouponResponse GetCouponUser(int couponId,int userId)
    {
        var query = QueryCouponsUser(userId).Include(x => x.Partner).AsQueryable();
        query = query.Where(x => x.Id == couponId);

        string code = string.Empty;
        var use = _context.CouponUsers.Where(x => x.CouponId == couponId && x.AccountId == userId)
            .FirstOrDefault();

        if (use != null)
            code = use.Code; 

        AvailableCouponResponse obj = query.Select(x => new AvailableCouponResponse()
        {
            Id = x.Id,
            AccountId = userId,
            Title = x.Title,
            Description = x.Description,
            Regulation = x.Regulation,
            QuantityUsed = x.QuantityUsed,
            FinishAt = x.FinishAt.Value.ToString("dd/MM/yyyy"),
            Partner = new PartnerResponse()
            {
                Id = x.PartnerId,
                Name = x.Partner.Name,
                PictureUrl = x.Partner.PictureUrl
            },
            Code = code
        }).FirstOrDefault();

        if (obj == null)
            throw new AppException("Cupom não enocntrado");

        return obj;
    }

    public IQueryable<Coupon> QueryCouponsUser(int userId)
    {

        var participantIds = _context.ParticipantUser.Where(x => x.AccountId == userId).Select(x => x.Id);

        var query = (from coupon in _context.Set<Coupon>()
                     join couponParticipant in _context.Set<CouponParticipant>()
                         on coupon.Id equals couponParticipant.CouponId
                     where coupon.CanceledAt==null &&  participantIds.Contains(couponParticipant.ParticipantId)
                     select coupon).AsQueryable();
        return query.AsQueryable();
    }

    public IQueryable<Coupon> QueryActivatedCoupons(int userId)
    {
        var query = (from coupon in _context.Set<Coupon>()
                     join couponUser in _context.Set<CouponUser>()
                         on coupon.Id equals couponUser.CouponId
                     where coupon.CanceledAt == null && couponUser.AccountId==userId
                     select coupon).AsQueryable();
        return query;
    }

    public IList<AvailableCouponResponse> GetAvailableCoupons(int userId)
    {
        var query = QueryCouponsUser(userId).Include(x=>x.Partner).AsQueryable();

        query = query.Where(x => x.StartAt <= DateTime.Now && x.FinishAt > DateTime.Now 
        && (x.QuantityMaxUse==null || x.QuantityUsed<x.QuantityMaxUse.Value)
        );

        var list = query.Select(x => new AvailableCouponResponse()
        { 
            Id = x.Id, 
            AccountId = userId,
            Title = x.Title,
            Description = x.Description,
            Regulation = x.Regulation,
            QuantityUsed = x.QuantityUsed,
            FinishAt = x.FinishAt.Value.ToString("dd/MM/yyyy"),
            Partner = new PartnerResponse()
            { 
                Id = x.PartnerId,
                Name = x.Partner.Name,
                PictureUrl = x.Partner.PictureUrl
            }
        }).ToList();
        return list;
    }
    public IList<Coupon> GetUnvailableCoupons(int userId)
    {
        var query = QueryCouponsUser(userId);
        query = query.Where(x => x.FinishAt < DateTime.Now || x.QuantityUsed >= x.QuantityMaxUse.Value);
        var list = query.ToList();
        return list;
    }

    public IList<Coupon> GetActivatedCoupons(int userId)
    {
        var query = QueryActivatedCoupons(userId);
        query = query.Where(x => x.UseLimiteDate > DateTime.Now);
        var list = query.ToList();
        return list;
    }

    public void ActivateCoupon(int userId,int couponId)
    {
        var coupon = _context.Coupons.Find(couponId);

        if (coupon==null || !coupon.IsAvailable)
            throw new AppException("Cupom não existe ou não está mais disponível");

        if(!GetAvailableCoupons(userId).Select(x=>x.Id).Contains(couponId))
            throw new AppException("Cupom não disponível para o usuário");

        var qtdActivatedCoupons = QueryActivatedCoupons(userId).Where(x => x.Id == couponId).Count(); ;
        if (qtdActivatedCoupons >= coupon.QuantityMaxUseUser)
            throw new AppException("Limite de uso por usuário atingido");

        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string code = new string(Enumerable.Repeat(chars, 6)
          .Select(s => s[random.Next(s.Length)]).ToArray());

        CouponUser obj = new CouponUser()
        {
            AccountId = userId,
            CouponId = couponId,
            ActivatedDate = DateTime.Now,
            UseDate = null,
            Code = code
        };
        _context.CouponUsers.Add(obj);

        coupon.QuantityUsed++;
        coupon.LastUse = DateTime.Now;
        _context.Coupons.Update(coupon);

        _context.SaveChanges();
    }

}