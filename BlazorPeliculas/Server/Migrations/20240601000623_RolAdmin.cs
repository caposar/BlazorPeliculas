using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPeliculas.Server.Migrations
{
    /// <inheritdoc />
    public partial class RolAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO AspNetRoles(Id, Name, NormalizedName)
                                   VALUES('6153e5d5-d238-4239-8868-5ab23616de6e', 'admin', 'ADMIN')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles WHERE Id = '6153e5d5-d238-4239-8868-5ab23616de6e'");
        }
    }
}
