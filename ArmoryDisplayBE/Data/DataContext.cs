using ArmoryDisplayBE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmoryDisplayBE.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RelationshipBuilder(modelBuilder);
            SeedData(modelBuilder);
        }

        public void RelationshipBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasMany(e => e.Heroes)
                .WithMany(e => e.Users)
                .UsingEntity<UserHero>();

            modelBuilder
                .Entity<User>()
                .HasMany(e => e.Socials)
                .WithMany(e => e.Users)
                .UsingEntity<UserSocials>();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Stats>()
                .HasData(
                    new Stats { Id = 1, Name = "Health" },
                    new Stats { Id = 2, Name = "Attack" },
                    new Stats { Id = 3, Name = "Defense" },
                    new Stats { Id = 4, Name = "Speed" },
                    new Stats { Id = 5, Name = "Critical Rate" },
                    new Stats { Id = 6, Name = "Critical Damage" },
                    new Stats { Id = 7, Name = "Effectiveness" },
                    new Stats { Id = 8, Name = "Effect Resistance" }
                );

            modelBuilder
                .Entity<GearType>()
                .HasData(
                    new GearType { Id = 1, Name = "Helmet" },
                    new GearType { Id = 2, Name = "Armor" },
                    new GearType { Id = 3, Name = "Boots" },
                    new GearType { Id = 4, Name = "Weapon" },
                    new GearType { Id = 5, Name = "Necklace" },
                    new GearType { Id = 6, Name = "Ring" }
                );

            modelBuilder
                .Entity<GearSets>()
                .HasData(
                    new GearSets
                    {
                        Id = 1,
                        Name = "Speed Set",
                        BonusStatsId = 4,
                        BonusStatsValue = 25,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 2,
                        Name = "Critical Set",
                        BonusStatsId = 5,
                        BonusStatsValue = 12,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 3,
                        Name = "Hit Set",
                        BonusStatsId = 7,
                        BonusStatsValue = 20,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 4,
                        Name = "Health Set",
                        BonusStatsId = 1,
                        BonusStatsValue = 20,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 5,
                        Name = "Attack Set",
                        BonusStatsId = 2,
                        BonusStatsValue = 45,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 6,
                        Name = "Defense Set",
                        BonusStatsId = 3,
                        BonusStatsValue = 20,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 7,
                        Name = "Protection Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 8,
                        Name = "Resist Set",
                        BonusStatsId = 8,
                        BonusStatsValue = 20,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 9,
                        Name = "Destruction Set",
                        BonusStatsId = 6,
                        BonusStatsValue = 60,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 10,
                        Name = "Lifesteal Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 11,
                        Name = "Counter Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 12,
                        Name = "Unity Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 13,
                        Name = "Immunity Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 14,
                        Name = "Rage Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 15,
                        Name = "Revenge Set",
                        BonusStatsId = 4,
                        BonusStatsValue = 12,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 16,
                        Name = "Penetration Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 17,
                        Name = "Torrent Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = true,
                    },
                    new GearSets
                    {
                        Id = 18,
                        Name = "Injury Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 19,
                        Name = "Reversal Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = false,
                    },
                    new GearSets
                    {
                        Id = 20,
                        Name = "Riposte Set",
                        BonusStatsId = null,
                        BonusStatsValue = null,
                        IsTwoPiece = false,
                    }
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
        public DbSet<GearSets> GearSets => Set<GearSets>();
        public DbSet<Stats> Stats => Set<Stats>();
        public DbSet<GearType> GearTypes => Set<GearType>();
        public DbSet<UserHeroGear> UserHeroGears => Set<UserHeroGear>();
        public DbSet<UserHeroGearStats> UserHeroGearStats => Set<UserHeroGearStats>();
    }
}
