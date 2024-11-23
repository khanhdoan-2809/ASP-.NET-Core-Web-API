using Microsoft.EntityFrameworkCore;

namespace ASP_.NET_Core_Web_API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) { }
        
        // public DbSet<bla> bla { get; set; }
    
    }
}
