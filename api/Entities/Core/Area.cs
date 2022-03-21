using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.Core
{
    public class Area
    {
        public int Id { get; set; }
        
        public string Description { get; set; }
       
    }

    public class AreaTypeConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("areas");
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Description).HasMaxLength(200).IsRequired();
            builder.HasIndex(x => x.Description).IsUnique();
        }


    }
}
