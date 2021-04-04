using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.DbContext.EF
{
    public class TamsDbContext : IdentityDbContext
    {
        public TamsDbContext(DbContextOptions<TamsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Ignore IdentityUser table not to create it in our db.
            builder.Ignore<IdentityUser>();


        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
