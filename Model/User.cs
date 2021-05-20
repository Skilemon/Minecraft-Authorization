namespace Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public string XboxName { get; set; }
        public bool Auth { get; set; }
        public UserIdentityEnum Identity { get; set; }
    }
}
