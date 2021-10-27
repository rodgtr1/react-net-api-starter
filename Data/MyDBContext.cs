
using Microsoft.EntityFrameworkCore;
using reactnet_tutorial.Models;

namespace reactnet_tutorial.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<Note> Notes { get; set; }
    }
}
