using Microsoft.EntityFrameworkCore;
using CyberCongratulator.Models;

namespace CyberCongratulator {
    public class AppDBContext : DbContext {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Person> Person { get; set; }
    }
}
