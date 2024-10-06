using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Challenge.API.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Celular = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    cpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    cep = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    tipoPlano = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    usuarioidUsuario = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.cpf_cnpj);
                    table.ForeignKey(
                        name: "FK_Cliente_Usuario_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dentista",
                columns: table => new
                {
                    cpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    cepClinica = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    nomeClinica = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    tipoClinica = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    alvaraFuncionamento = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    siteRedesSocial = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    usuarioidUsuario = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentista", x => x.cpf_cnpj);
                    table.ForeignKey(
                        name: "FK_Dentista_Usuario_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    idConsulta = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    dateConsulta = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    tipoConsulta = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    valorMedioConsulta = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    dentistacpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    clientecpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.idConsulta);
                    table.ForeignKey(
                        name: "FK_Consulta_Cliente_clientecpf_cnpj",
                        column: x => x.clientecpf_cnpj,
                        principalTable: "Cliente",
                        principalColumn: "cpf_cnpj");
                    table.ForeignKey(
                        name: "FK_Consulta_Dentista_dentistacpf_cnpj",
                        column: x => x.dentistacpf_cnpj,
                        principalTable: "Dentista",
                        principalColumn: "cpf_cnpj",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_usuarioidUsuario",
                table: "Cliente",
                column: "usuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_clientecpf_cnpj",
                table: "Consulta",
                column: "clientecpf_cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_dentistacpf_cnpj",
                table: "Consulta",
                column: "dentistacpf_cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_Dentista_usuarioidUsuario",
                table: "Dentista",
                column: "usuarioidUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Dentista");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
