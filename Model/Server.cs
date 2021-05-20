namespace Model
{
    public class Server : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ServerStatusEnum Status { get; set; }
        public string Description { get; set; }
    }
}
