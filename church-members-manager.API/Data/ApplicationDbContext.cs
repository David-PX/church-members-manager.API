using church_members_manager.API.Models;
using Microsoft.EntityFrameworkCore;

namespace church_members_manager.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Member> Members { get; set; }
    }
}
