using ArmoryDisplayBE.Models;
using Microsoft.EntityFrameworkCore;

namespace ArmoryDisplayBE.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasMany(e => e.Heroes)
                .WithMany(e => e.Users)
                .UsingEntity<UserHero>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=.\\SqlExpress;Database=armorydisplay;TrustedConnection=true;TrustServerCertificate=true;"
            );
        }

        public DbSet<Constellation> Constellations => Set<Constellation>();
        public DbSet<Element> Elements => Set<Element>();
        public DbSet<Hero> Heroes => Set<Hero>();
        public DbSet<HeroBaseStats> HeroBaseStats => Set<HeroBaseStats>();
        public DbSet<HeroClass> HeroClasses => Set<HeroClass>();
        public DbSet<HeroRarity> HeroRarities => Set<HeroRarity>();
        public DbSet<Server> Servers => Set<Server>();
        public DbSet<Socials> Socials => Set<Socials>();
        public DbSet<SpecialtyChangeBonusStats> SpecialtyChangeBonusStats =>
            Set<SpecialtyChangeBonusStats>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserHero> UserHeroes => Set<UserHero>();
        public DbSet<UserSocials> UserSocials => Set<UserSocials>();
    }
}
