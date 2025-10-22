using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbDANHMUC",
                columns: table => new
                {
                    IDDANHMUC = table.Column<int>(type: "int", nullable: false),
                    TENDANHMUC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbMENU",
                columns: table => new
                {
                    IDMON = table.Column<int>(type: "int", nullable: false),
                    TENMON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DONVITINH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DONGIA = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    HINHANH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDDANHMUC = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbDANHMUC");

            migrationBuilder.DropTable(
                name: "tbMENU");
        }
    }
}
