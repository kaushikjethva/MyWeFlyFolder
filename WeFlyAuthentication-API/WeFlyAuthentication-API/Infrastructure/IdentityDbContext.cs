using WeFlyAuthentication_API.Models;
using Microsoft.EntityFrameworkCore;

namespace WeFlyAuthentication_API.Infrastructure
{
    public class IdentityDbContext:DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {

        }
        public DbSet<clsUser> Users { get; set; }
    }
}
