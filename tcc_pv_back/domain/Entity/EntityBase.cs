namespace Domain
{
    public class EntityBase
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Description { get; set; } = "";
    }
}