namespace Domain.Model
{
    public class ProdutoModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Description { get; set; } = "";

        public string Validade { get; set; } = "";
    }
}
