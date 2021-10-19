using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_PeriferiaIT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vuelos",
                columns: table => new
                {
                    VueloID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudadOrigen = table.Column<string>(type: "varchar(100)", nullable: true),
                    CiudadDestino = table.Column<string>(type: "varchar(100)", nullable: true),
                    Fecha = table.Column<string>(type: "varchar(100)", nullable: true),
                    HoraSalida = table.Column<string>(type: "varchar(100)", nullable: true),
                    HoraLlegada = table.Column<string>(type: "varchar(100)", nullable: true),
                    NumeroVuelo = table.Column<int>(type: "int", nullable: false),
                    Aerolinia = table.Column<string>(type: "varchar(100)", nullable: true),
                    EstadoVuelo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelos", x => x.VueloID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vuelos");
        }
    }
}
