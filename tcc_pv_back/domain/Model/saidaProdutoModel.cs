namespace domain.Model
{
    public class saidaProdutoModel
    {
        public string id { get; set; } = Guid.NewGuid().ToString();

        public DateTime data { get; set; }

        public string Description { get; set; } = "";
    }
}