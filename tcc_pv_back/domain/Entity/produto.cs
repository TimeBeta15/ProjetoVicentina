namespace domain
{
    public class produto
    {
        public int Id { get; set; } // Código do Produto

        public string Nome { get; set; } // Nome do Produto

        public int Quantidade { get; set; } // Verifica a quantidade do Produto

        public bool Validade { get; set; } // Verificar se está vencido
    }
}