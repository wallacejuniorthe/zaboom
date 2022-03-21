using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Core
{
    public class Coupon
    {
        public int Id { get; set; }
        public Partner Partner { get; set; }
        public int PartnerId { get; set; }
        public string Description { get; set; }
        public string Regulation { get; set; }
        public int QuantityUsed { get; set; }
        public int QuantityMaxUse { get; set; }
        public int QuantityMaxUseUser { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? FinishAt { get; set; }
        public DateTime? CanceledAt { get; set; }
        public DateTime? LastUse { get; set; }
        
        [NotMapped]
        public bool IsAvailable
        {
            get
            {
                return CanceledAt == null && QuantityUsed < QuantityMaxUse;
            }
        }
    }

    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable("coupons");
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Description).HasMaxLength(200).IsRequired();
            builder.Property(t => t.Regulation).HasMaxLength(5000).IsRequired();
            builder.Property(x => x.CreatedAt).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);
        }


    }
}
