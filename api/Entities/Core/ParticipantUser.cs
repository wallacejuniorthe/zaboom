using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Core
{
    public class ParticipantUser
    {
        public int Id { get; set; }
        public Participant Participant { get; set; }
        public int ParticipantId { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class ParticipantUserConfiguration : IEntityTypeConfiguration<ParticipantUser>
    {
        public void Configure(EntityTypeBuilder<ParticipantUser> builder)
        {
            builder.ToTable("participants_users");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.AccountId, x.ParticipantId }).IsUnique();
            builder.Property(x => x.CreatedAt).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);
        }


    }
}
