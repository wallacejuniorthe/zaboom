namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApi.Entities;
using WebApi.Entities.Core;
using WebApi.Entities.Core.Base;

public class DataContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Partner> Partners { get; set; }
    public DbSet<Coupon> Coupons { get; set; }
    
    public DbSet<CouponUser> CouponUsers { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventType> EventTypes { get; set; }
    public DbSet<Segment> Segments { get; set; }
    public DbSet<Area> Area { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<ParticipantUser> ParticipantUser { get; set; }
    public DbSet<CouponParticipant> CouponParticipants { get; set; }

    private readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        options.LogTo(Console.WriteLine);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var typesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces()
               .Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))).ToList();

        foreach (var type in typesToRegister)
        {
            dynamic configurationInstance = Activator.CreateInstance(type);
            modelBuilder.ApplyConfiguration(configurationInstance);
        }

        base.OnModelCreating(modelBuilder);
    }
}