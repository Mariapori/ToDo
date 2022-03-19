using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todoMember_SharedTodos_SharedTodoId",
                table: "todoMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_todoMember",
                table: "todoMember");

            migrationBuilder.RenameTable(
                name: "todoMember",
                newName: "TodoMembers");

            migrationBuilder.RenameIndex(
                name: "IX_todoMember_SharedTodoId",
                table: "TodoMembers",
                newName: "IX_TodoMembers_SharedTodoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoMembers",
                table: "TodoMembers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoMembers_SharedTodos_SharedTodoId",
                table: "TodoMembers",
                column: "SharedTodoId",
                principalTable: "SharedTodos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoMembers_SharedTodos_SharedTodoId",
                table: "TodoMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoMembers",
                table: "TodoMembers");

            migrationBuilder.RenameTable(
                name: "TodoMembers",
                newName: "todoMember");

            migrationBuilder.RenameIndex(
                name: "IX_TodoMembers_SharedTodoId",
                table: "todoMember",
                newName: "IX_todoMember_SharedTodoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_todoMember",
                table: "todoMember",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_todoMember_SharedTodos_SharedTodoId",
                table: "todoMember",
                column: "SharedTodoId",
                principalTable: "SharedTodos",
                principalColumn: "Id");
        }
    }
}
