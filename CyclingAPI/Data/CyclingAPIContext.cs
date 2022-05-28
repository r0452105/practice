using Microsoft.EntityFrameworkCore;
using CyclingAPILib;

namespace CyclingAPI.Data
{
    public class CyclingAPIContext : DbContext
    {
        public CyclingAPIContext (DbContextOptions<CyclingAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Cyclist> Cyclist { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cyclist>().HasKey(e => e.Id);

            var cyclists = new Cyclist[]
            {
                new Cyclist(){ FirstName="Aaron", LastName="Sprangers", Nationality="Belgium", Id=1000000},
                new Cyclist(){ FirstName="Kevin", LastName="Ceusters", Nationality="Belgium", Id=1000001},
            };

            modelBuilder.Entity<Cyclist>().HasData(cyclists);
            base.OnModelCreating(modelBuilder);
        }
    }
}
