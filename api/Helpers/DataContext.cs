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

        SeedData(modelBuilder);
    }

    private Partner GetPartner(int id, string name, string cnpj)
    {
        Partner partner = new Partner()
        {
            Id = id,
            Name = name,
            Cnpj = cnpj,
            Email = $"{name}@teste.com",
            CreatedAt = DateTime.Now,
            Contact = "Contato",
            Phone1 = "Phone1",
            Street = "Rua X",
            District = "Bairro",
            City = "Teresina",
            State = "PI",
            PostalCode = "64014050",
            SegmentId = 1,
            PictureUrl= "https://random.imagecdn.app/500/150"
        };
        return partner;
    }
    private Participant GetParticipant(int id, string name, string cnpj)
    {
        Participant obj = new Participant()
        {
            Id = id,
            Name = name,
            Cnpj = cnpj,
            Email = $"{name}@teste.com",
            CreatedAt = DateTime.Now,
            Contact = "Contato",
            Phone1 = "Phone1",
            Street = "Rua X",
            District = "Bairro",
            City = "Teresina",
            State = "PI",
            PostalCode = "64014050",
            AreaId = 1
        };
        return obj;
    }
    private Account GetAccount(int id, string name, DateTime? verified)
    {
        Account obj = new Account()
        {
            Id = id,
            Name = name,
            Email = $"{name}@teste.com",
            PasswordHash = "$2a$11$jurHlZ3Jf1AOIrkKMLcsBueo0JYM8mWVCi6w4QTE9Rx1yKJC2WV/q",
            AcceptTerms = true,
            Role = Role.User,
            VerificationToken = "583422",
            Verified = verified,
            Created = DateTime.Now
        };
        return obj;
    }
    private Coupon GetCoupon(int id, string title, string description,string regulation,int partnerId, int? quantityMaxUse,
        int? quantityMaxUseUser, DateTime startAt, DateTime finishAt, DateTime limiteDate)
    {
        Coupon obj = new Coupon()
        {
            Id = id,
            Title = title,
            Description = description,
            CreatedAt = DateTime.Now,
            PartnerId = partnerId,
            QuantityMaxUse = quantityMaxUse,
            QuantityMaxUseUser = quantityMaxUseUser,
            StartAt = startAt,
            FinishAt = finishAt,
            Regulation = regulation,
            UseLimiteDate = limiteDate

        };
        return obj;
    }
    

    private void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Segment>().HasData(
            new Area() { Id = 1, Description = "Segmento 1" },
            new Area() { Id = 2, Description = "Segmento 2" }
        );

        modelBuilder.Entity<Area>().HasData(
            new Area() { Id = 1, Description = "Area 1" },
            new Area() { Id = 2, Description = "Area 2" }
        );

        modelBuilder.Entity<Partner>().HasData(
            GetPartner(1, "Empresa1", "123456"),
            GetPartner(2, "Empresa2", "1234567"),
            GetPartner(3, "Empresa3", "1234568"),
            GetPartner(4,"Empresa4","12345699")
        );

        modelBuilder.Entity<Participant>().HasData(
            GetParticipant(1, "Participant1", "123456"),
            GetParticipant(2, "Participant2", "1234567"),
            GetParticipant(3, "Participant3", "1234568"),
            GetParticipant(4, "Participant4", "12345699")
        );

        modelBuilder.Entity<Account>().HasData(
            GetAccount(1, "User1", DateTime.Now),
            GetAccount(2, "User2", DateTime.Now),
            GetAccount(3, "User3", null),
            GetAccount(4, "User4", null),
            GetAccount(5, "User5", DateTime.Now),
            GetAccount(6, "User6", DateTime.Now),
            GetAccount(7, "User7", DateTime.Now),
            GetAccount(8, "User8", DateTime.Now),
            GetAccount(9, "User9", DateTime.Now)
        );

        modelBuilder.Entity<ParticipantUser>().HasData(
            new ParticipantUser() { Id = 1, ParticipantId = 1, AccountId = 1, CreatedAt = DateTime.Now},
            new ParticipantUser() { Id = 2, ParticipantId = 1, AccountId = 2, CreatedAt = DateTime.Now },
            new ParticipantUser() { Id = 3, ParticipantId = 1, AccountId = 3, CreatedAt = DateTime.Now },
            new ParticipantUser() { Id = 4, ParticipantId = 2, AccountId = 4, CreatedAt = DateTime.Now },
            new ParticipantUser() { Id = 5, ParticipantId = 2, AccountId = 5, CreatedAt = DateTime.Now },
            new ParticipantUser() { Id = 6, ParticipantId = 2, AccountId = 6, CreatedAt = DateTime.Now },
            new ParticipantUser() { Id = 7, ParticipantId = 3, AccountId = 7, CreatedAt = DateTime.Now },
            new ParticipantUser() { Id = 8, ParticipantId = 3, AccountId = 8, CreatedAt = DateTime.Now },
            new ParticipantUser() { Id = 9, ParticipantId = 3, AccountId = 9, CreatedAt = DateTime.Now }
        );

        modelBuilder.Entity<Coupon>().HasData(
            GetCoupon(1,"Cupom 1", "Cupom 1 - dewr rewrr rer", "Resulamento xx xx x x", 1, 50, 1, DateTime.Now, DateTime.Now.AddDays(5), DateTime.Now.AddDays(15)),
            GetCoupon(2, "Cupom 2", "Cupom 2 - dewr rewrr rer", "Resulamento xx xx x x", 1, 50, 5, DateTime.Now, DateTime.Now.AddDays(5), DateTime.Now.AddDays(15)),
            GetCoupon(3, "Cupom 3", "Cupom 3 - dewr rewrr rer", "Resulamento xx xx x x", 1, null,null, DateTime.Now, DateTime.Now.AddDays(15), DateTime.Now.AddDays(15)),
            GetCoupon(4, "Cupom 4", "Cupom 4 - dewr rewrr rer", "Resulamento xx xx x x", 2, null, null, DateTime.Now, DateTime.Now.AddDays(15), DateTime.Now.AddDays(15)),
            GetCoupon(5, "Cupom 5", "Cupom 5 - dewr rewrr rer", "Resulamento xx xx x x", 2, null, 1, DateTime.Now, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(15)),
            GetCoupon(6, "Cupom 6", "Cupom 6 - dewr rewrr rer", "Resulamento xx xx x x", 2, 50, null, DateTime.Now, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(15)),
            GetCoupon(7, "Cupom 7", "Cupom 7 - dewr rewrr rer", "Resulamento xx xx x x", 3, 50, 1, DateTime.Now, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(15)),
            GetCoupon(8, "Cupom 8", "Cupom 8 - dewr rewrr rer", "Resulamento xx xx x x", 3, 50, 1, DateTime.Now, DateTime.Now.AddDays(5), DateTime.Now.AddDays(15)),
            GetCoupon(9, "Cupom 9", "Cupom 9 - dewr rewrr rer", "Resulamento xx xx x x", 3, 50, 1, DateTime.Now, DateTime.Now.AddDays(5), DateTime.Now.AddDays(15)),
            GetCoupon(10, "Cupom 10", "Cupom 10 - dewr rewrr rer", "Resulamento xx xx x x", 4, 50, 1, DateTime.Now, DateTime.Now.AddDays(5), DateTime.Now.AddDays(15)),
            GetCoupon(11, "Cupom 11", "Cupom 11 - dewr rewrr rer", "Resulamento xx xx x x",4,50,1,DateTime.Now,DateTime.Now.AddDays(5), DateTime.Now.AddDays(15))
        );

        modelBuilder.Entity<CouponParticipant>().HasData(
            new CouponParticipant { Id = 1, CouponId = 1, ParticipantId = 1, CreatedAt = DateTime.Now },
            new CouponParticipant { Id = 2, CouponId = 1, ParticipantId = 2, CreatedAt = DateTime.Now },
            new CouponParticipant { Id = 3, CouponId = 1, ParticipantId = 3, CreatedAt = DateTime.Now },
            new CouponParticipant { Id = 4, CouponId = 2, ParticipantId = 1, CreatedAt = DateTime.Now },
            new CouponParticipant { Id = 5, CouponId = 3, ParticipantId = 1, CreatedAt = DateTime.Now },
            new CouponParticipant { Id = 6, CouponId = 4, ParticipantId = 1, CreatedAt = DateTime.Now },
            new CouponParticipant { Id = 7, CouponId = 5, ParticipantId = 1, CreatedAt = DateTime.Now }
        );
    }

}