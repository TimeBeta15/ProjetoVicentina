namespace Domain.Model
{
    public class tabelaFornecedorModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Data { get; set; } = "";

        public string Nome { get; set; } = "";

        public string Telefone { get; set; } = "";

        public string NomeProduto { get; set; } = "";

        public string Categoria { get; set; } =  "";

        public int Quantidade { get; set; }
    }
}
