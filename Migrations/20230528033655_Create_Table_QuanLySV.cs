using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QL_SinhVien.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_QuanLySV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SDT",
                table: "QuanLySV",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SDT",
                table: "QuanLySV");
        }
    }
}
