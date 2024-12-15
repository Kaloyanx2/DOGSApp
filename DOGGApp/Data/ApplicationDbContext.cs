using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DOGGApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal readonly object Dogs;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}