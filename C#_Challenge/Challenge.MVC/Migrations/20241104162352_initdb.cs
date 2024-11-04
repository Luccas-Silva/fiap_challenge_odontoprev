using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Challenge.MVC.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Celular = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    cpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    cep = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    tipoPlano = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    usuarioidUsuario = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.cpf_cnpj);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Usuario_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Dentista",
                columns: table => new
                {
                    cpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    cepClinica = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    nomeClinica = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    tipoClinica = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    alvaraFuncionamento = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    siteRedesSocial = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    usuarioidUsuario = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Dentista", x => x.cpf_cnpj);
                    table.ForeignKey(
                        name: "FK_tb_Dentista_tb_Usuario_usuarioidUsuario",
                        column: x => x.usuarioidUsuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Consulta",
                columns: table => new
                {
                    idConsulta = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    dateConsulta = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    tipoConsulta = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    valorMedioConsulta = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    dentistacpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    clientecpf_cnpj = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Consulta", x => x.idConsulta);
                    table.ForeignKey(
                        name: "FK_tb_Consulta_tb_Cliente_clientecpf_cnpj",
                        column: x => x.clientecpf_cnpj,
                        principalTable: "tb_Cliente",
                        principalColumn: "cpf_cnpj",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Consulta_tb_Dentista_dentistacpf_cnpj",
                        column: x => x.dentistacpf_cnpj,
                        principalTable: "tb_Dentista",
                        principalColumn: "cpf_cnpj",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cliente_usuarioidUsuario",
                table: "tb_Cliente",
                column: "usuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Consulta_clientecpf_cnpj",
                table: "tb_Consulta",
                column: "clientecpf_cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Consulta_dentistacpf_cnpj",
                table: "tb_Consulta",
                column: "dentistacpf_cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Dentista_usuarioidUsuario",
                table: "tb_Dentista",
                column: "usuarioidUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Consulta");

            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_Dentista");

            migrationBuilder.DropTable(
                name: "tb_Usuario");
        }
    }
}
