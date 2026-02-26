using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CINEMA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NM_NAME = table.Column<string>(type: "text", nullable: false),
                    ST_ACTIVE = table.Column<bool>(type: "boolean", nullable: false),
                    ST_IS_DELETED = table.Column<bool>(type: "boolean", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "timestamp with time zone", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CINEMA", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CINEMA");
        }
    }
}
