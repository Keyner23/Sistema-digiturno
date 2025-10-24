using Digiturno.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Digiturno.web.Data;


public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Affiliate> Afiliados  { get; set; }
    public DbSet<Turn> Turnos  { get; set; }
    
    
}
