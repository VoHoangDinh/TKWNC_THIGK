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
                name: "tbNHOM",
                columns: table => new
                {
                    MANHOM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNHOM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNHOM", x => x.MANHOM);
                });

            migrationBuilder.CreateTable(
                name: "tbTHIETBI",
                columns: table => new
                {
                    MATHIETBI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTHIETBI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DONVITINH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    DONGIA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HINHANH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MANHOM = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTHIETBI", x => x.MATHIETBI);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbNHOM");

            migrationBuilder.DropTable(
                name: "tbTHIETBI");
        }
    }
}
