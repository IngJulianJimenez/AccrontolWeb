using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    Empresaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sede_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    Areaid = table.Column<int>(type: "int", nullable: false),
                    Sedeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajador", x => x.id);
                    table.ForeignKey(
                        name: "FK_Trabajador_Area_Areaid",
                        column: x => x.Areaid,
                        principalTable: "Area",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trabajador_Sede_Sedeid",
                        column: x => x.Sedeid,
                        principalTable: "Sede",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administracion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trabajadorid = table.Column<int>(type: "int", nullable: false),
                    descripcionAdm = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administracion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Administracion_Trabajador_Trabajadorid",
                        column: x => x.Trabajadorid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    Trabajadorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroHora", x => x.id);
                    table.ForeignKey(
                        name: "FK_RegistroHora_Trabajador_Trabajadorid",
                        column: x => x.Trabajadorid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supervisor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trabajadorid = table.Column<int>(type: "int", nullable: false),
                    descripcionSpr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.id);
                    table.ForeignKey(
                        name: "FK_Supervisor_Trabajador_Trabajadorid",
                        column: x => x.Trabajadorid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuperAdminTrabajador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trabajadorid = table.Column<int>(type: "int", nullable: false),
                    Supervisorid = table.Column<int>(type: "int", nullable: true),
                    Administracionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAdminTrabajador", x => x.id);
                    table.ForeignKey(
                        name: "FK_SuperAdminTrabajador_Administracion_Administracionid",
                        column: x => x.Administracionid,
                        principalTable: "Administracion",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_SuperAdminTrabajador_Supervisor_Supervisorid",
                        column: x => x.Supervisorid,
                        principalTable: "Supervisor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_SuperAdminTrabajador_Trabajador_Trabajadorid",
                        column: x => x.Trabajadorid,
                        principalTable: "Trabajador",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administracion_Trabajadorid",
                table: "Administracion",
                column: "Trabajadorid");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroHora_Trabajadorid",
                table: "RegistroHora",
                column: "Trabajadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Empresaid",
                table: "Sede",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_SuperAdminTrabajador_Administracionid",
                table: "SuperAdminTrabajador",
                column: "Administracionid");

            migrationBuilder.CreateIndex(
                name: "IX_SuperAdminTrabajador_Supervisorid",
                table: "SuperAdminTrabajador",
                column: "Supervisorid");

            migrationBuilder.CreateIndex(
                name: "IX_SuperAdminTrabajador_Trabajadorid",
                table: "SuperAdminTrabajador",
                column: "Trabajadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisor_Trabajadorid",
                table: "Supervisor",
                column: "Trabajadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajador_Areaid",
                table: "Trabajador",
                column: "Areaid");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajador_Sedeid",
                table: "Trabajador",
                column: "Sedeid");
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
