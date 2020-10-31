using Microsoft.EntityFrameworkCore;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class CommadContext : DbContext
    {
        public CommadContext(DbContextOptions<CommadContext> options) : base(options)
        {

        }
        public DbSet<Command> CommandItems { get; set; }
    }
}