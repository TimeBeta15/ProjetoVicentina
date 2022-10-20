namespace domain.Model
{
    public class entradaProdutoModel
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public DateTime data { get; set; }
        public string nome { get; set; } = "";
        public int quantidade{get; set;}
        public DateTime validade { get; set;}
        public string Categoria {get; set;}= "";
    }
}