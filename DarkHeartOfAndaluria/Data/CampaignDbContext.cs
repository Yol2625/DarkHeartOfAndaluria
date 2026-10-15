using Microsoft.EntityFrameworkCore;
using DarkHeartOfAndaluria.Models;
namespace DarkHeartOfAndaluria.Data
{
    public class CampaignDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Npc> Npcs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Npc>()
                .HasOne(npc => npc.HomeCity)
                .WithMany()
                .HasForeignKey(npc => npc.HomeCityId)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Npc>()
            .HasOne(npc => npc.CurrentCity)
             .WithMany()
          .HasForeignKey(npc => npc.CurrentCityId)
          .OnDelete(DeleteBehavior.Restrict);
            


        }
        public CampaignDbContext(DbContextOptions<CampaignDbContext> options) : base(options)
        {

        }


    }


}