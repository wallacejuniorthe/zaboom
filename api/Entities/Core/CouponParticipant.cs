using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Core
{
    public class CouponParticipant
    {
        public int Id { get; set; }
        public Coupon Coupon { get; set; }
        public int CouponId { get; set; }
        public Participant Participant { get; set; }
        public int ParticipantId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CouponParticipantConfiguration : IEntityTypeConfiguration<CouponParticipant>
    {
        public void Configure(EntityTypeBuilder<CouponParticipant> builder)
        {
            builder.ToTable("coupons_participants");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.CouponId, x.ParticipantId }).IsUnique();
            builder.Property(x => x.CreatedAt).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);
        }


    }
}
