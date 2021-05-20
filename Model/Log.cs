namespace Model
{
    public class Log : BaseEntity
    {
        public string Name { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }
}
