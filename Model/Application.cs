namespace Model
{
    public class Application : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public string Version { get; set; }
        public string BeianNumber { get; set; }
    }
}
