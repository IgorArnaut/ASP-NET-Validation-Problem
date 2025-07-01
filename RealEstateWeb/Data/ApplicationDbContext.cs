using Microsoft.EntityFrameworkCore;
using RealEstateWeb.Models;

namespace RealEstateWeb.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Terms> Terms { get; set; }
        public DbSet<Listing> Listings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item() { Id = 1, Name = "Ležaj" },
                new Item() { Id = 2, Name = "Plakar" },
                new Item() { Id = 3, Name = "Klima" },
                new Item() { Id = 4, Name = "Telefon" },
                new Item() { Id = 5, Name = "TV" },
                new Item() { Id = 6, Name = "Internet" },
                new Item() { Id = 7, Name = "Kuhinjski elementi" },
                new Item() { Id = 8, Name = "Mikrotalasna" },
                new Item() { Id = 9, Name = "Šporet" },
                new Item() { Id = 10, Name = "Rerna" },
                new Item() { Id = 11, Name = "Rešo" },
                new Item() { Id = 12, Name = "Frižider" },
                new Item() { Id = 13, Name = "Zamrzivač" },
                new Item() { Id = 14, Name = "Sudomašina" },
                new Item() { Id = 15, Name = "Veš mašina" },
                new Item() { Id = 16, Name = "Kancelarijski nameštaj" },
                new Item() { Id = 17, Name = "Terasa" },
                new Item() { Id = 18, Name = "Ležaj" }
            );

            modelBuilder.Entity<Building>()
                .HasOne(b => b.Address)
                .WithOne(a => a.Building)
                .HasForeignKey<Address>(a => a.BuildingId)
                .IsRequired();

            modelBuilder.Entity<Apartment>()
             .HasMany(a => a.Items)
             .WithMany(i => i.Apartments);
        }
    }
}
