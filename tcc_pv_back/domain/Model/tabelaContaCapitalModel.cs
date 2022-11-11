namespace domain.Model
{
    public class tabelaContaCapitalModel
    {
        public string id { get; set; } = Guid.NewGuid().ToString();

        public string data { get; set; }

        public string Description { get; set; } = "";

        public float Entrada { get; set; }

        public float Saida { get; set; }

        public float Valor { get; set; }
    }
}
