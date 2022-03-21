using Microsoft.AspNetCore.Mvc;
using WebApi.Authorization;
using WebApi.Entities.Core;
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

        [HttpGet("available-cupons")]
        public IList<Coupon> AvailableCoupons()
        {
            return _couponService.GetAvailableCoupons(Account.Id);
        }

        [HttpGet("activated-cupons")]
        public String ActivatedCoupons()
        {
            return this.Account.Name;
        }

        [HttpGet("used-cupons")]
        public String UsedCoupons()
        {
            return this.Account.Name;
        }
    }
}
