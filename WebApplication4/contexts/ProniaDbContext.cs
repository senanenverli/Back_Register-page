using WebApplication4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplication4.contexts
{
    public class ProniaDbContext : IdentityDbContext<AppUser>
    {

        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {

        }
        public DbSet<Shipping>? Shippings { get; set; }
        public DbSet<product> Products { get; set; }
    }
}
