// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using testapi.Entities;

namespace testapi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }
    }
}
