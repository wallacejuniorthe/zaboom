using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Core.Base
{
    public class Event
    {
        public int Id { get; set; }
        public EventType EventType { get; set; }
        public int EventTypeId { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int? Key1 { get; set; }
        public string Key2 { get; set; }
        public string Value { get; set; }

    }

    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("events");
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Description).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.EventType).WithMany().HasForeignKey(x => x.EventTypeId);
        }


    }
}
