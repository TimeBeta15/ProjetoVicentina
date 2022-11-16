namespace Domain.Model
{
    public class tabelaQuartoModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Data { get; set; } = "";

        public string Nome { get; set; } = "";

        public int NumeroQuarto { get; set; }
    }
}
