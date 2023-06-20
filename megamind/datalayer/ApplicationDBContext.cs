using megamind.Models;
using Microsoft.EntityFrameworkCore;

namespace megamind.datalayer
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) 
        { 
        
        }
        public DbSet<form> forms { get; set; }
    }
}
