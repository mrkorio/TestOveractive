using Microsoft.EntityFrameworkCore.Migrations;

namespace TestOveractive.DAL.Migrations
{
    public partial class AddingEntitiesKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_TiposPermisos_TipoPermisoId",
                table: "Permisos");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TiposPermisos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoPermisoId",
                table: "Permisos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreEmpleado",
                table: "Permisos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApellidosEmpleado",
                table: "Permisos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_TiposPermisos_TipoPermisoId",
                table: "Permisos",
                column: "TipoPermisoId",
                principalTable: "TiposPermisos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_TiposPermisos_TipoPermisoId",
                table: "Permisos");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TiposPermisos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "TipoPermisoId",
                table: "Permisos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NombreEmpleado",
                table: "Permisos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ApellidosEmpleado",
                table: "Permisos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_TiposPermisos_TipoPermisoId",
                table: "Permisos",
                column: "TipoPermisoId",
                principalTable: "TiposPermisos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
