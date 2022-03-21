using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace WebApi.Entities.Core
{    
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public DateTime CreatedAt { get; set; }
        public Area Area { get; set; }
        public int AreaId { get; set; }
        public string Comments { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Details { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

    }

    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.ToTable("participants");
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Name).HasMaxLength(200).IsRequired();
            builder.Property(t => t.Cnpj).HasMaxLength(20).IsRequired();
            builder.Property(t => t.Contact).HasMaxLength(200).IsRequired();
            builder.Property(t => t.Email).HasMaxLength(200).IsRequired();
            builder.Property(t => t.Phone1).HasMaxLength(30).IsRequired();
            builder.Property(t => t.Phone2).HasMaxLength(20);
            builder.Property(t => t.Comments).HasMaxLength(2000);
            builder.Property(x => x.CreatedAt).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Property(t => t.Street).HasMaxLength(200).IsRequired();
            builder.Property(t => t.Number).HasMaxLength(20);
            builder.Property(t => t.Details).HasMaxLength(200);
            builder.Property(t => t.District).HasMaxLength(200).IsRequired();
            builder.Property(t => t.City).HasMaxLength(200).IsRequired();
            builder.Property(t => t.State).HasMaxLength(2).IsRequired();
            builder.Property(t => t.PostalCode).HasMaxLength(20).IsRequired();

            builder.HasIndex(x => x.Cnpj).IsUnique();
        }


    }
}
