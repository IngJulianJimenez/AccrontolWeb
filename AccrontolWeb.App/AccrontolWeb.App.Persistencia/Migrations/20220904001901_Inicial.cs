using Microsoft.EntityFrameworkCore.Migrations;

namespace AccrontolWeb.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombreSede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idEmpresaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sede_Empresa_idEmpresaid",
                        column: x => x.idEmpresaid,
                        principalTable: "Empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trabajador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<int>(type: "int", nullable: false),
                    idAreaid = table.Column<int>(type: "int", nullable: true),
                    idSedeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajador", x => x.id);
                    table.ForeignKey(
                        name: "FK_Trabajador_Area_idAreaid",
                        column: x => x.idAreaid,
                        principalTable: "Area",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trabajador_Sede_idSedeid",
                        column: x => x.idSedeid,
                        principalTable: "Sede",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Administracion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTrabajadorAdmid = table.Column<int>(type: "int", nullable: true),
                    descripcionAdm = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administracion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Administracion_Trabajador_idTrabajadorAdmid",
                        column: x => x.idTrabajadorAdmid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroHora",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    horaInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horaFinal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcionHh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTrabajadorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroHora", x => x.id);
                    table.ForeignKey(
                        name: "FK_RegistroHora_Trabajador_idTrabajadorid",
                        column: x => x.idTrabajadorid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supervisor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTrabajadorSprid = table.Column<int>(type: "int", nullable: true),
                    descripcionSpr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.id);
                    table.ForeignKey(
                        name: "FK_Supervisor_Trabajador_IdTrabajadorSprid",
                        column: x => x.IdTrabajadorSprid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuperAdminTrabajador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTrabajadorid = table.Column<int>(type: "int", nullable: true),
                    idSupervisorid = table.Column<int>(type: "int", nullable: true),
                    idAdministradorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAdminTrabajador", x => x.id);
                    table.ForeignKey(
                        name: "FK_SuperAdminTrabajador_Administracion_idAdministradorid",
                        column: x => x.idAdministradorid,
                        principalTable: "Administracion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuperAdminTrabajador_Supervisor_idSupervisorid",
                        column: x => x.idSupervisorid,
                        principalTable: "Supervisor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuperAdminTrabajador_Trabajador_idTrabajadorid",
                        column: x => x.idTrabajadorid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administracion_idTrabajadorAdmid",
                table: "Administracion",
                column: "idTrabajadorAdmid");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroHora_idTrabajadorid",
                table: "RegistroHora",
                column: "idTrabajadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_idEmpresaid",
                table: "Sede",
                column: "idEmpresaid");

            migrationBuilder.CreateIndex(
                name: "IX_SuperAdminTrabajador_idAdministradorid",
                table: "SuperAdminTrabajador",
                column: "idAdministradorid");

            migrationBuilder.CreateIndex(
                name: "IX_SuperAdminTrabajador_idSupervisorid",
                table: "SuperAdminTrabajador",
                column: "idSupervisorid");

            migrationBuilder.CreateIndex(
                name: "IX_SuperAdminTrabajador_idTrabajadorid",
                table: "SuperAdminTrabajador",
                column: "idTrabajadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisor_IdTrabajadorSprid",
                table: "Supervisor",
                column: "IdTrabajadorSprid");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajador_idAreaid",
                table: "Trabajador",
                column: "idAreaid");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajador_idSedeid",
                table: "Trabajador",
                column: "idSedeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroHora");

            migrationBuilder.DropTable(
                name: "SuperAdminTrabajador");

            migrationBuilder.DropTable(
                name: "Administracion");

            migrationBuilder.DropTable(
                name: "Supervisor");

            migrationBuilder.DropTable(
                name: "Trabajador");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
