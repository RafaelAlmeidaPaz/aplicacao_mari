using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AlterIngressoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"
    ALTER TABLE Ingresso
ALTER COLUMN NroDias int;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
