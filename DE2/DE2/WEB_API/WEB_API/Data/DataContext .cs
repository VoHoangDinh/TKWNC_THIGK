using Microsoft.EntityFrameworkCore;
using WEB_API.Models; // Quan trọng: using namespace của Models

namespace WEB_API.Data // Namespace đúng
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<tbDanhMuc> tbDANHMUC { get; set; }
        public DbSet<tbMenu> tbMENU { get; set; }

        // DbSet để hứng kết quả từ SP sp_Get_Menu_ByDanhMuc và sp_Get_Mon_ById
        public DbSet<tbMenu> MenuResults { get; set; }

        // DbSet để hứng kết quả từ SP sp_GetAll_DanhMuc
        public DbSet<tbDanhMuc> DanhMucResults { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Báo cho EF Core biết các DbSet ...Results không phải là bảng thật
            modelBuilder.Entity<tbMenu>().HasNoKey().ToView(null);
            modelBuilder.Entity<tbDanhMuc>().HasNoKey().ToView(null);

            // Cấu hình kiểu dữ liệu decimal nếu cần (để tránh warning)
            modelBuilder.Entity<tbMenu>()
                .Property(p => p.DONGIA)
                .HasColumnType("numeric(18, 0)");

            // Gọi base method
            base.OnModelCreating(modelBuilder);
        }
    }
}