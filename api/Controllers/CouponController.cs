using Microsoft.AspNetCore.Mvc;
using WebApi.Authorization;
using WebApi.Entities.Core;
using WebApi.Models.Accounts;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CouponController : BaseController
    {
        private readonly CouponService _couponService;

        public CouponController(CouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet("available-coupons")]
        public IList<AvailableCouponResponse> AvailableCupons()
        {
            return _couponService.GetAvailableCoupons(Account.Id);
        }

        [HttpGet("detail/{id}")]
        public AvailableCouponResponse Coupon(int id)
        {
            return _couponService.GetCouponUser(id,Account.Id);
        }

        [HttpGet("activated-coupons")]
        public IList<Coupon> ActivatedCoupons()
        {
            return _couponService.GetActivatedCoupons(Account.Id);
        }

        [HttpGet("used-coupons")]
        public String UsedCoupons()
        {
            return this.Account.Name;
        }

        [HttpPost("activate-coupon")]
        public IActionResult ActivateCoupon(ActivateCouponRequest obj)
        {
            _couponService.ActivateCoupon(this.Account.Id, obj.Id);
            return Ok(new { message = "Cupom ativado com sucesso" });


        }

    }
}
