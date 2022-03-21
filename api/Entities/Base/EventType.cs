using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Core
{
    public class EventType
    {
        public int Id { get; set; }
        
        public string Description { get; set; }
       
    }

    public class EventTypeConfiguration : IEntityTypeConfiguration<EventType>
    {
        public void Configure(EntityTypeBuilder<EventType> builder)
        {
            builder.ToTable("event_types");
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Description).HasMaxLength(200).IsRequired();
            builder.HasIndex(x => x.Description).IsUnique();
        }


    }
}
