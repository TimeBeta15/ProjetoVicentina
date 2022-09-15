namespace domain
{
    public class funcionario
    {
        public int Id { get; set; } // Código da Pessoa

        public string Nome { get; set; } // Nome da Pessoa

        public DateTime Nascimento { get; set; } // Data de Nascimento

        public bool Vacina { get; set; } // Se tomou vacina se sim, qual?

        public bool Comorbidade { get; set; } // Se tem comorbidade se sim, qual?

        public int telefone { get; set; } // Possui algum contato?F

        public double Cpf { get; set; } // CPF da Pessoa
    }
}