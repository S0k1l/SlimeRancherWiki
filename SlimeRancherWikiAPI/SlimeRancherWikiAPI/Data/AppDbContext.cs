using Microsoft.EntityFrameworkCore;
using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Diet> Diets { get; set; }
        public DbSet<DietFood> DietFoods { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodLocation> FoodLocations { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Plort> Plorts { get; set; }
        public DbSet<Slime> Slimes { get; set; }
        public DbSet<SlimeDiet> SlimeDiets { get; set; }
        public DbSet<SlimeLocation> SlimeLocations { get; set; }
        public DbSet<Toy> Toys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many-to-Many relationships

            modelBuilder.Entity<DietFood>()
                .HasKey(df => new { df.DietId, df.FoodId });
            modelBuilder.Entity<DietFood>()
                .HasOne(f => f.Food)
                .WithMany(df => df.DietFood)
                .HasForeignKey(df => df.FoodId);
            modelBuilder.Entity<DietFood>()
                .HasOne(d => d.Diet)
                .WithMany(df => df.DietFood)
                .HasForeignKey(df => df.DietId);

            modelBuilder.Entity<FoodLocation>()
                .HasKey(fl => new { fl.FoodId, fl.LocationId });
            modelBuilder.Entity<FoodLocation>()
                .HasOne(f => f.Food)
                .WithMany(fl => fl.FoodLocation)
                .HasForeignKey(fl => fl.FoodId);
            modelBuilder.Entity<FoodLocation>()
                .HasOne(l => l.Location)
                .WithMany(fl => fl.FoodLocation)
                .HasForeignKey(fl => fl.LocationId);

            modelBuilder.Entity<SlimeDiet>()
                .HasKey(sd => new { sd.SlimeId, sd.DietId });
            modelBuilder.Entity<SlimeDiet>()
                .HasOne(s => s.Slime)
                .WithMany(sd => sd.SlimeDiet)
                .HasForeignKey(sd => sd.SlimeId);
            modelBuilder.Entity<SlimeDiet>()
                .HasOne(d => d.Diet)
                .WithMany(sd => sd.SlimeDiet)
                .HasForeignKey(sd => sd.DietId);

            modelBuilder.Entity<SlimeLocation>()
                .HasKey(sl => new { sl.SlimeId, sl.LocationId });
            modelBuilder.Entity<SlimeLocation>()
                .HasOne(s => s.Slime)
                .WithMany(sl => sl.SlimeLocation)
                .HasForeignKey(sl => sl.SlimeId);
            modelBuilder.Entity<SlimeLocation>()
                .HasOne(l => l.Location)
                .WithMany(sl => sl.SlimeLocation)
                .HasForeignKey(sl => sl.LocationId);


            //One-to-One relationships

            modelBuilder.Entity<Food>()
                .HasOne(f => f.Slime)
                .WithOne(s => s.FavFood)
                .HasForeignKey<Slime>(s => s.FavFoodId);

            modelBuilder.Entity<Toy>()
                .HasOne(t => t.Slime)
                .WithOne(s => s.Toy)
                .HasForeignKey<Slime>(s => s.ToyId);

            modelBuilder.Entity<Plort>()
                .HasOne(p => p.Slime)
                .WithOne(s => s.Plort)
                .HasForeignKey<Slime>(s => s.PlortId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
