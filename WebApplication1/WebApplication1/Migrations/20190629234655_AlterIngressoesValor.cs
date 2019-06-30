using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class AlterIngressoesValor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"
    ALTER TABLE Ingresso
ALTER COLUMN ValorBasico float;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
