using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastrar_WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pf",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    cpf = table.Column<string>(type: "TEXT", nullable: true),
                    idade = table.Column<int>(type: "INTEGER", nullable: false),
                    telefone = table.Column<string>(type: "TEXT", nullable: true),
                    endereco = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pf", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pj",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    razsoc = table.Column<string>(type: "TEXT", nullable: true),
                    cnpj = table.Column<string>(type: "TEXT", nullable: true),
                    endereco = table.Column<string>(type: "TEXT", nullable: true),
                    telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pj", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Pf",
                columns: new[] { "id", "cpf", "endereco", "idade", "nome", "telefone" },
                values: new object[] { 1, "111.111.111-11", "rua: xyz", 22, "Marta", "(17)99150-9019" });

            migrationBuilder.InsertData(
                table: "Pf",
                columns: new[] { "id", "cpf", "endereco", "idade", "nome", "telefone" },
                values: new object[] { 2, "111.111.111-11", "rua: xyz", 22, "Paula", "(17)99150-9019" });

            migrationBuilder.InsertData(
                table: "Pf",
                columns: new[] { "id", "cpf", "endereco", "idade", "nome", "telefone" },
                values: new object[] { 3, "111.111.111-11", "rua: xyz", 22, "Laura", "(17)99150-9019" });

            migrationBuilder.InsertData(
                table: "Pf",
                columns: new[] { "id", "cpf", "endereco", "idade", "nome", "telefone" },
                values: new object[] { 4, "111.111.111-11", "rua: xyz", 22, "Luiza", "(17)99150-9019" });

            migrationBuilder.InsertData(
                table: "Pf",
                columns: new[] { "id", "cpf", "endereco", "idade", "nome", "telefone" },
                values: new object[] { 5, "111.111.111-11", "rua: xyz", 22, "Lucas", "(17)99150-9019" });

            migrationBuilder.InsertData(
                table: "Pf",
                columns: new[] { "id", "cpf", "endereco", "idade", "nome", "telefone" },
                values: new object[] { 6, "111.111.111-11", "rua: xyz", 22, "Pedro", "(17)99150-9019" });

            migrationBuilder.InsertData(
                table: "Pf",
                columns: new[] { "id", "cpf", "endereco", "idade", "nome", "telefone" },
                values: new object[] { 7, "111.111.111-11", "rua: xyz", 22, "Paulo", "(17)99150-9019" });

            migrationBuilder.InsertData(
                table: "Pj",
                columns: new[] { "id", "cnpj", "endereco", "razsoc", "telefone" },
                values: new object[] { 1, "111.111.111/0001-1", "rua: xjh", "data par", "(17)3333-3333" });

            migrationBuilder.InsertData(
                table: "Pj",
                columns: new[] { "id", "cnpj", "endereco", "razsoc", "telefone" },
                values: new object[] { 2, "222.222.222/0001-1", "rua: abc", "riopretrans", "(17)3333-3333" });

            migrationBuilder.InsertData(
                table: "Pj",
                columns: new[] { "id", "cnpj", "endereco", "razsoc", "telefone" },
                values: new object[] { 3, "333.333.333/0001-1", "rua: yaz", "transreal", "(17)3333-3333" });

            migrationBuilder.InsertData(
                table: "Pj",
                columns: new[] { "id", "cnpj", "endereco", "razsoc", "telefone" },
                values: new object[] { 4, "444.444.444/0001-1", "rua: asd", "real rondonia", "(17)3333-3333" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pf");

            migrationBuilder.DropTable(
                name: "Pj");
        }
    }
}
