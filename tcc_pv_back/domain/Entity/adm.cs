namespace domain.Entity
{
    public class adm
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Nome { get; set; }
        public string Email { get; set; }
        public string  Senha { get; set; }
    }
}