using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo.Migrations.todosorsa
{
    public partial class todos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_aspnetusers_LuojaId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_LuojaId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "LuojaId",
                table: "Todos");

            migrationBuilder.AddColumn<string>(
                name: "Luoja",
                table: "Todos",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_general_ci")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Luoja",
                table: "Todos");

            migrationBuilder.AddColumn<string>(
                name: "LuojaId",
                table: "Todos",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                collation: "utf8mb4_general_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_LuojaId",
                table: "Todos",
                column: "LuojaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_aspnetusers_LuojaId",
                table: "Todos",
                column: "LuojaId",
                principalTable: "aspnetusers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
