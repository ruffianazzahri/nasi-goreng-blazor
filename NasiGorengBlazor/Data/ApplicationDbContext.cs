using Microsoft.EntityFrameworkCore;
using NasiGorengBlazor.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<NasiGoreng> NasiGorengs { get; set; }
}
