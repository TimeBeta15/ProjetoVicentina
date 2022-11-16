namespace domain.Model
{
    public class entradaProdutoModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        
        public string Data { get; set; } = "";
        
        public string Nome { get; set; } = "";
        
        public int Quantidade{get; set;}
        
        public string Validade { get; set;} = "";
        
        public string Categoria {get; set;}= "";
    }
}
