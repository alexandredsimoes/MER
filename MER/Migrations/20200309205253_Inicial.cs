using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MER.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiarios",
                columns: table => new
                {
                    clienteCodigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteNome = table.Column<string>(nullable: true),
                    clienteCNPJ = table.Column<string>(nullable: true),
                    planoCodigo = table.Column<int>(nullable: false),
                    planoNome = table.Column<string>(nullable: true),
                    benefCodigo = table.Column<int>(nullable: false),
                    benefCartao = table.Column<string>(nullable: true),
                    benefMatricula = table.Column<string>(nullable: true),
                    benefNome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiarios", x => x.clienteCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    lojaCodigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    redeCodigo = table.Column<int>(nullable: false),
                    redeCNPJ = table.Column<string>(nullable: true),
                    redeNome = table.Column<string>(nullable: true),
                    lojaCNPJ = table.Column<string>(nullable: true),
                    lojaNome = table.Column<string>(nullable: true),
                    lojaUF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.lojaCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    skuCodigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    skuEAN = table.Column<string>(nullable: true),
                    industriaNome = table.Column<string>(nullable: true),
                    produtoNome = table.Column<string>(nullable: true),
                    skuNome = table.Column<string>(nullable: true),
                    adesao = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.skuCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    codigoVenda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoOrigem = table.Column<int>(nullable: false),
                    codigoNSUOrigem = table.Column<int>(nullable: false),
                    codigoNSU = table.Column<int>(nullable: false),
                    dataVenda = table.Column<DateTime>(nullable: false),
                    prescritorTipo = table.Column<string>(nullable: true),
                    prescritorNumero = table.Column<string>(nullable: true),
                    prescritorUF = table.Column<string>(nullable: true),
                    prescritorNome = table.Column<string>(nullable: true),
                    cupomFiscal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.codigoVenda);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    itemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    produtoskuCodigo = table.Column<int>(nullable: true),
                    quantidade = table.Column<int>(nullable: false),
                    valorPMC = table.Column<float>(nullable: false),
                    valorDesconto = table.Column<float>(nullable: false),
                    taxaDesconto = table.Column<float>(nullable: false),
                    valorVenda = table.Column<float>(nullable: false),
                    valorCopay = table.Column<float>(nullable: false),
                    valorRepasse = table.Column<float>(nullable: false),
                    valorSubsidioEPH = table.Column<float>(nullable: false),
                    taxaSubsidioEPH = table.Column<float>(nullable: false),
                    valorSubsidioCliente = table.Column<float>(nullable: false),
                    taxaSubsidioCliente = table.Column<float>(nullable: false),
                    valorDescontoFolha = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.itemId);
                    table.ForeignKey(
                        name: "FK_Items_Produtos_produtoskuCodigo",
                        column: x => x.produtoskuCodigo,
                        principalTable: "Produtos",
                        principalColumn: "skuCodigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_produtoskuCodigo",
                table: "Items",
                column: "produtoskuCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiarios");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Lojas");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
