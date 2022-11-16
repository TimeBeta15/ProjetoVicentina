namespace Domain.Model
{
    public class tabelaDoadorModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Data { get; set; } = "";

        public string Nome { get; set; } = "";

        public string Telefone { get; set; } = "";

        public string FormaDoacao { get; set; } = "";

        public float Valor { get; set; }
    }
}
