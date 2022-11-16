namespace Domain
{
    public class EntityBase
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Description { get; set; } = "";

        public string Data { get; set; } = "";

        public string Nome { get; set; } = "";

        public int Quantidade { get; set; }

        public string Validade { get; set; } = "";

        public string Categoria { get; set; } = "";

        public float Entrada { get; set; }

        public float Saida { get; set; }

        public float Valor { get; set; }

        public string dataRegistro { get; set; } = "";

        public string dataNiver { get; set; } = "";

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

        public int NumeroQuarto { get; set; }

        public string FormaDoacao { get; set; } = "";

        public string NomeProduto { get; set; } = "";
    }
}
