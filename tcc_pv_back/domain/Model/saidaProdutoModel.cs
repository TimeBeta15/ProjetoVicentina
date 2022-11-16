namespace Domain.Model
{
    public class saidaProdutoModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Data { get; set; } = "";

        public string Description { get; set; } = "";
    }
}
