using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Core
{
    public class Segment
    {
        public int Id { get; set; }
        
        public string Description { get; set; }
       
    }

    public class SegmentTypeConfiguration : IEntityTypeConfiguration<Segment>
    {
        public void Configure(EntityTypeBuilder<Segment> builder)
        {
            builder.ToTable("segments");
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Description).HasMaxLength(200).IsRequired();
            builder.HasIndex(x => x.Description).IsUnique();
        }


    }
}
