using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UpSchool_Observer_DesignPattern.DAL
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-ISO96UVH\\SQLEXPRESS;Database=DbObserver;integrated security=True;");


        }
        public DbSet<Discount> Discounts { get; set; }


    }
}
