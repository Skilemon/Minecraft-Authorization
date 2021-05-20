namespace Model
{
    public class UserAndServer : BaseEntity
    {
        public int UserID { get; set; }
        public int ServerID { get; set; }
        public UserAndServerStatusEnum Status { get; set; }
    }
}
