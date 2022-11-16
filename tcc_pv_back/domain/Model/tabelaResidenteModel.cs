namespace Domain.Model
{
    public class tabelaResidenteModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string DataRegistro { get; set; } = "";

        public string Nome { get; set; } = "";

        public string DataNiver { get; set; } = "";

        public string Genero { get; set; } = "";

        public bool IsAposentado { get; set; }

        public string Endereco { get; set; } = "";

        public bool EmprestimoNome { get; set; }

        public string GrauDependencia { get; set; } = "";

        public string AnyDeficiencia { get; set; } = "";

        public string AnyDoenca { get; set; } = "";

        public string TomaRemedio { get; set; } = "";

        public string Motivo { get; set; } = "";

        public string NomePessoaInstituicao { get; set; } = "";

        public string GrauParentesco { get; set; } = "";

        public string Telefone { get; set; } = "";
    }
}
