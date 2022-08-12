namespace Domain
{
    public class Contaspagar
    {
        public int id { get; set; }
        public Datetime datavencimento { get; set; }
        public Datatime datapagamento { get; set; }
        public double valor{ get; set; }
    }
}