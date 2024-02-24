using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Justo.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Justo-ADV");

            migrationBuilder.CreateTable(
                name: "Processos",
                schema: "Justo-ADV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_processo_TJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome_reu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_processo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comarca_inicial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conteudo_inicial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Obs_processo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_fim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Polo_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessosDetalhesId = table.Column<int>(type: "int", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cadastradopor = table.Column<int>(type: "int", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizadopor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Site_contato",
                schema: "Justo-ADV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_contato = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Telefone_contato = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Email_contato = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Assunto_contato = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Conteudo_contato = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Tipo_causa_contato = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Analisado_contato = table.Column<bool>(type: "bit", nullable: false),
                    Virar_cliente_contato = table.Column<bool>(type: "bit", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cadastradopor = table.Column<int>(type: "int", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizadopor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site_contato", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Advogados",
                schema: "Justo-ADV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Oab = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    Oab_UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Status_Oab_Ativo = table.Column<bool>(type: "bit", nullable: false),
                    ProcessosId = table.Column<int>(type: "int", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cadastradopor = table.Column<int>(type: "int", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizadopor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advogados", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Advogados_Processos_ProcessosId",
                        column: x => x.ProcessosId,
                        principalSchema: "Justo-ADV",
                        principalTable: "Processos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                schema: "Justo-ADV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_cliente = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Cpf_cliente = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Rg_cliente = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    Cnh_cliente = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Contrato_social_cliente = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Cnpj_cliente = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Certificado_reservista_cliente = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Procuracao_representacao_legal_cliente = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Genero_cliente = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    Data_nascimento_cliente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ocupacao_cliente = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Nacionalidade_cliente = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Estado_civil_cliente = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Banco_cliente = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Agencia_bancaria_cliente = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Telefone_cliente = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Contato_de_confianca_cliente = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: true),
                    Email_cliente = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    Tipo_cliente = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false),
                    ProcessoId = table.Column<int>(type: "int", nullable: false),
                    ProcessosId = table.Column<int>(type: "int", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cadastradopor = table.Column<int>(type: "int", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizadopor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clientes_Processos_ProcessosId",
                        column: x => x.ProcessosId,
                        principalSchema: "Justo-ADV",
                        principalTable: "Processos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Advogados_Especialidades",
                schema: "Justo-ADV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_area_direito = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false),
                    AdvogadoId = table.Column<int>(type: "int", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cadastradopor = table.Column<int>(type: "int", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizadopor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advogados_Especialidades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Advogados_Especialidades_Advogados_AdvogadoId",
                        column: x => x.AdvogadoId,
                        principalSchema: "Justo-ADV",
                        principalTable: "Advogados",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                schema: "Justo-ADV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cadastradopor = table.Column<int>(type: "int", nullable: false),
                    data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    atualizadopor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "Justo-ADV",
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processos_ClientesReu",
                schema: "Justo-ADV",
                columns: table => new
                {
                    ProcessoId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    DataEntrouNoProcesso = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos_ClientesReu", x => new { x.ProcessoId, x.ClienteId });
                    table.ForeignKey(
                        name: "FK_Processos_ClientesReu_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "Justo-ADV",
                        principalTable: "Clientes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Processos_ClientesReu_Processos_ProcessoId",
                        column: x => x.ProcessoId,
                        principalSchema: "Justo-ADV",
                        principalTable: "Processos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advogados_cpf",
                schema: "Justo-ADV",
                table: "Advogados",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advogados_Oab",
                schema: "Justo-ADV",
                table: "Advogados",
                column: "Oab",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advogados_ProcessosId",
                schema: "Justo-ADV",
                table: "Advogados",
                column: "ProcessosId");

            migrationBuilder.CreateIndex(
                name: "IX_Advogados_Especialidades_AdvogadoId",
                schema: "Justo-ADV",
                table: "Advogados_Especialidades",
                column: "AdvogadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProcessosId",
                schema: "Justo-ADV",
                table: "Clientes",
                column: "ProcessosId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClienteId",
                schema: "Justo-ADV",
                table: "Endereco",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processos_ClientesReu_ClienteId",
                schema: "Justo-ADV",
                table: "Processos_ClientesReu",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advogados_Especialidades",
                schema: "Justo-ADV");

            migrationBuilder.DropTable(
                name: "Endereco",
                schema: "Justo-ADV");

            migrationBuilder.DropTable(
                name: "Processos_ClientesReu",
                schema: "Justo-ADV");

            migrationBuilder.DropTable(
                name: "Site_contato",
                schema: "Justo-ADV");

            migrationBuilder.DropTable(
                name: "Advogados",
                schema: "Justo-ADV");

            migrationBuilder.DropTable(
                name: "Clientes",
                schema: "Justo-ADV");

            migrationBuilder.DropTable(
                name: "Processos",
                schema: "Justo-ADV");
        }
    }
}
