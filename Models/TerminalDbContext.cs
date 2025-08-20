using Microsoft.EntityFrameworkCore;

namespace Resume.Models;

public class TerminalDbContext : DbContext
{
    public TerminalDbContext(DbContextOptions<TerminalDbContext> options) 
        : base(options) { }

    public DbSet<TerminalModel> TerminalItems { get; set; }
}