using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Blog_Demo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Posts> Posts { get; set; }
        public DbSet<PostTypes> PostTypes { get; set; }

        public ApplicationDbContext()
            : base("Blog-Demo", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}