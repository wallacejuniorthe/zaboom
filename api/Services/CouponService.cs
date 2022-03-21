namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
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

    public IQueryable<Coupon> QueryCouponsUser(int userId)
    {

        var participantIds = _context.ParticipantUser.Where(x => x.AccountId == userId).Select(x => x.Id);

        var query = (from coupon in _context.Set<Coupon>()
                     join couponParticipant in _context.Set<CouponParticipant>()
                         on coupon.Id equals couponParticipant.CouponId
                     where participantIds.Contains(couponParticipant.ParticipantId)
                     select coupon).AsQueryable();
        return query;
    }

    public IList<Coupon> GetAvailableCoupons(int userId)
    {
        var query = QueryCouponsUser(userId);
        query = query.Where(x => x.StartAt >= DateTime.Now && x.FinishAt < DateTime.Now && x.CanceledAt == null);
        var list = query.ToList();
        Console.WriteLine(list);
        return list;
    }
    public IList<Coupon> GetUnvailableCoupons(int userId)
    {
        var query = QueryCouponsUser(userId);
        query = query.Where(x => x.FinishAt < DateTime.Now || x.CanceledAt != null);
        var list = query.ToList();
        Console.WriteLine(list);
        return list;
    }

    public void CouponUser(int userId,int couponId)
    {
        var coupon = _context.Coupons.Find(couponId);
        if (!coupon.IsAvailable)
            throw new AppException("Coupon is unavaiable");

        CouponUser obj = new CouponUser()
        {
            AccountId = userId,
            CouponId = couponId
        };
        _context.CouponUsers.Add(obj);

        coupon.QuantityUsed++;
        coupon.LastUse = DateTime.Now;
        _context.Coupons.Update(coupon);

        _context.SaveChanges();
    }

}