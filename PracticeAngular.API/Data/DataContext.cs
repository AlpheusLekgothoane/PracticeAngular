using Microsoft.EntityFrameworkCore;
using PracticeAngular.API.Models;

namespace PracticeAngular.API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options): base(options){  }
    public DbSet<Value> values { get; set; }

  }
}