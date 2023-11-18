using JusProcessos.Models;
using Microsoft.EntityFrameworkCore;

namespace JusProcessos.Data
{
    public class TesteContext : DbContext
    {
        public TesteContext(DbContextOptions<TesteContext> options) : base(options) 
        {
        
        }
        public DbSet<Thor> Teste { get; set; }
    }
}
