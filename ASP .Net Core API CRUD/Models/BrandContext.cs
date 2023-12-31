using Microsoft.EntityFrameworkCore;

namespace ASP_.Net_Core_API_CRUD.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {
            
        }
        public DbSet<Brand> Brands { get; set; }
    }
}
