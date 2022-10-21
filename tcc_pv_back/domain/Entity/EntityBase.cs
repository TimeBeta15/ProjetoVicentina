namespace Domain
{
    public class EntityBase
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Description { get; set; } = "";
        public DateTime data { get; set; }
        public string nome { get; set; } = "";
        public int quantidade { get; set; }
        public DateTime validade { get; set; }
        public string Categoria { get; set; } = "";

        public float Entrada { get; set; }

        public float Saida { get; set; }

        public float Valor { get; set; }
    }
}