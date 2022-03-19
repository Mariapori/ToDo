using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo.Migrations
{
    public partial class fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoMembers_SharedTodos_SharedTodoId",
                table: "TodoMembers");

            migrationBuilder.AlterColumn<int>(
                name: "SharedTodoId",
                table: "TodoMembers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TodoMembers_SharedTodos_SharedTodoId",
                table: "TodoMembers",
                column: "SharedTodoId",
                principalTable: "SharedTodos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoMembers_SharedTodos_SharedTodoId",
                table: "TodoMembers");

            migrationBuilder.AlterColumn<int>(
                name: "SharedTodoId",
                table: "TodoMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoMembers_SharedTodos_SharedTodoId",
                table: "TodoMembers",
                column: "SharedTodoId",
                principalTable: "SharedTodos",
                principalColumn: "Id");
        }
    }
}
