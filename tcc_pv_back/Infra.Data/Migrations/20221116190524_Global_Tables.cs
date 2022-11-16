using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class Global_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "validade",
                table: "tabelaVerbaMunicipal",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tabelaVerbaMunicipal",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tabelaVerbaMunicipal",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "tabelaVerbaMunicipal",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "tabelaVerbaEstadual",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tabelaVerbaEstadual",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tabelaVerbaEstadual",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "tabelaVerbaEstadual",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "tabelaEmendaParlamentar",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tabelaEmendaParlamentar",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tabelaEmendaParlamentar",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "tabelaEmendaParlamentar",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "tabelaEmendaImpositiva",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tabelaEmendaImpositiva",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tabelaEmendaImpositiva",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "tabelaEmendaImpositiva",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "tabelaContaCorrente",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tabelaContaCorrente",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tabelaContaCorrente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "tabelaContaCorrente",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "tabelaContaCapital",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tabelaContaCapital",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tabelaContaCapital",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "tabelaContaCapital",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "tabelaCaixa",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tabelaCaixa",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "tabelaCaixa",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "tabelaCaixa",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "saidaProduto",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "saidaProduto",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "saidaProduto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "saidaProduto",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "Produto",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "Produto",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Produto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Produto",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "validade",
                table: "entradaProduto",
                newName: "Validade");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "entradaProduto",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "entradaProduto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "entradaProduto",
                newName: "Data");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "tabelaVerbaMunicipal",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "tabelaVerbaMunicipal",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "tabelaVerbaMunicipal",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "tabelaVerbaMunicipal",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "tabelaVerbaEstadual",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "tabelaVerbaEstadual",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "tabelaVerbaEstadual",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "tabelaVerbaEstadual",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "tabelaEmendaParlamentar",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "tabelaEmendaParlamentar",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "tabelaEmendaParlamentar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "tabelaEmendaParlamentar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "tabelaEmendaImpositiva",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "tabelaEmendaImpositiva",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "tabelaEmendaImpositiva",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "tabelaEmendaImpositiva",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "tabelaContaCorrente",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "tabelaContaCorrente",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "tabelaContaCorrente",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "tabelaContaCorrente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "tabelaContaCapital",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "tabelaContaCapital",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "tabelaContaCapital",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "tabelaContaCapital",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "tabelaCaixa",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "tabelaCaixa",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "tabelaCaixa",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "tabelaCaixa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "saidaProduto",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "saidaProduto",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "saidaProduto",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "saidaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "Produto",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "Produto",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "Produto",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "Produto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDeficiencia",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnyDoenca",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmprestimoNome",
                table: "entradaProduto",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormaDoacao",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauDependencia",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrauParentesco",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAposentado",
                table: "entradaProduto",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePessoaInstituicao",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumeroQuarto",
                table: "entradaProduto",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TomaRemedio",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataNiver",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dataRegistro",
                table: "entradaProduto",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "tabelaDoador",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Validade = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    Entrada = table.Column<float>(type: "REAL", nullable: false),
                    Saida = table.Column<float>(type: "REAL", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    dataRegistro = table.Column<string>(type: "TEXT", nullable: false),
                    dataNiver = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    IsAposentado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    EmprestimoNome = table.Column<bool>(type: "INTEGER", nullable: false),
                    GrauDependencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDeficiencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDoenca = table.Column<string>(type: "TEXT", nullable: false),
                    TomaRemedio = table.Column<string>(type: "TEXT", nullable: false),
                    Motivo = table.Column<string>(type: "TEXT", nullable: false),
                    NomePessoaInstituicao = table.Column<string>(type: "TEXT", nullable: false),
                    GrauParentesco = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroQuarto = table.Column<int>(type: "INTEGER", nullable: false),
                    FormaDoacao = table.Column<string>(type: "TEXT", nullable: false),
                    NomeProduto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabelaDoador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tabelaFornecedor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Validade = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    Entrada = table.Column<float>(type: "REAL", nullable: false),
                    Saida = table.Column<float>(type: "REAL", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    dataRegistro = table.Column<string>(type: "TEXT", nullable: false),
                    dataNiver = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    IsAposentado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    EmprestimoNome = table.Column<bool>(type: "INTEGER", nullable: false),
                    GrauDependencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDeficiencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDoenca = table.Column<string>(type: "TEXT", nullable: false),
                    TomaRemedio = table.Column<string>(type: "TEXT", nullable: false),
                    Motivo = table.Column<string>(type: "TEXT", nullable: false),
                    NomePessoaInstituicao = table.Column<string>(type: "TEXT", nullable: false),
                    GrauParentesco = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroQuarto = table.Column<int>(type: "INTEGER", nullable: false),
                    FormaDoacao = table.Column<string>(type: "TEXT", nullable: false),
                    NomeProduto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabelaFornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tabelaQuarto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Validade = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    Entrada = table.Column<float>(type: "REAL", nullable: false),
                    Saida = table.Column<float>(type: "REAL", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    dataRegistro = table.Column<string>(type: "TEXT", nullable: false),
                    dataNiver = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    IsAposentado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    EmprestimoNome = table.Column<bool>(type: "INTEGER", nullable: false),
                    GrauDependencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDeficiencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDoenca = table.Column<string>(type: "TEXT", nullable: false),
                    TomaRemedio = table.Column<string>(type: "TEXT", nullable: false),
                    Motivo = table.Column<string>(type: "TEXT", nullable: false),
                    NomePessoaInstituicao = table.Column<string>(type: "TEXT", nullable: false),
                    GrauParentesco = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroQuarto = table.Column<int>(type: "INTEGER", nullable: false),
                    FormaDoacao = table.Column<string>(type: "TEXT", nullable: false),
                    NomeProduto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabelaQuarto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tabelaResidente",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Validade = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    Entrada = table.Column<float>(type: "REAL", nullable: false),
                    Saida = table.Column<float>(type: "REAL", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    dataRegistro = table.Column<string>(type: "TEXT", nullable: false),
                    dataNiver = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    IsAposentado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Endereco = table.Column<string>(type: "TEXT", nullable: false),
                    EmprestimoNome = table.Column<bool>(type: "INTEGER", nullable: false),
                    GrauDependencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDeficiencia = table.Column<string>(type: "TEXT", nullable: false),
                    AnyDoenca = table.Column<string>(type: "TEXT", nullable: false),
                    TomaRemedio = table.Column<string>(type: "TEXT", nullable: false),
                    Motivo = table.Column<string>(type: "TEXT", nullable: false),
                    NomePessoaInstituicao = table.Column<string>(type: "TEXT", nullable: false),
                    GrauParentesco = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroQuarto = table.Column<int>(type: "INTEGER", nullable: false),
                    FormaDoacao = table.Column<string>(type: "TEXT", nullable: false),
                    NomeProduto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabelaResidente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabelaDoador");

            migrationBuilder.DropTable(
                name: "tabelaFornecedor");

            migrationBuilder.DropTable(
                name: "tabelaQuarto");

            migrationBuilder.DropTable(
                name: "tabelaResidente");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "tabelaVerbaMunicipal");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "tabelaVerbaEstadual");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "tabelaEmendaParlamentar");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "tabelaEmendaImpositiva");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "tabelaContaCorrente");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "tabelaContaCapital");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "tabelaCaixa");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "saidaProduto");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "AnyDeficiencia",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "AnyDoenca",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "EmprestimoNome",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "FormaDoacao",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "GrauDependencia",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "GrauParentesco",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "IsAposentado",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "NomePessoaInstituicao",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "NumeroQuarto",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "TomaRemedio",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "dataNiver",
                table: "entradaProduto");

            migrationBuilder.DropColumn(
                name: "dataRegistro",
                table: "entradaProduto");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "tabelaVerbaMunicipal",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tabelaVerbaMunicipal",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tabelaVerbaMunicipal",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "tabelaVerbaMunicipal",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "tabelaVerbaEstadual",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tabelaVerbaEstadual",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tabelaVerbaEstadual",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "tabelaVerbaEstadual",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "tabelaEmendaParlamentar",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tabelaEmendaParlamentar",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tabelaEmendaParlamentar",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "tabelaEmendaParlamentar",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "tabelaEmendaImpositiva",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tabelaEmendaImpositiva",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tabelaEmendaImpositiva",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "tabelaEmendaImpositiva",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "tabelaContaCorrente",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tabelaContaCorrente",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tabelaContaCorrente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "tabelaContaCorrente",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "tabelaContaCapital",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tabelaContaCapital",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tabelaContaCapital",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "tabelaContaCapital",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "tabelaCaixa",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tabelaCaixa",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tabelaCaixa",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "tabelaCaixa",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "saidaProduto",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "saidaProduto",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "saidaProduto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "saidaProduto",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "Produto",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Produto",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Produto",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Validade",
                table: "entradaProduto",
                newName: "validade");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "entradaProduto",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "entradaProduto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "entradaProduto",
                newName: "data");
        }
    }
}
