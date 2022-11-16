namespace Domain.Model
{
    public class tabelaEmendaParlamentarModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Data { get; set; } = "";

        public string Description { get; set; } = "";

        public float Entrada { get; set; }

        public float Saida { get; set; }

        public float Valor { get; set; }
    }
}
