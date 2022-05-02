using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Core
{
    public class CouponUser
    {
        public int Id { get; set; }
        public Coupon Coupon { get; set; }
        public int CouponId { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public string? Code { get; set; }
        public DateTime ActivatedDate { get; set; }
        public DateTime? UseDate { get; set; }
    }

    public class CouponUserConfiguration : IEntityTypeConfiguration<CouponUser>
    {
        public void Configure(EntityTypeBuilder<CouponUser> builder)
        {
            builder.ToTable("coupons_users");
            builder.HasKey(x => x.Id);
        }


    }
}
