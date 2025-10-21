using Microsoft.EntityFrameworkCore;
using WEB_API.Models;

namespace WEB_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<tbNhom> tbNHOM { get; set; }
        public DbSet<tbThietBi> tbTHIETBI { get; set; }
    }
}