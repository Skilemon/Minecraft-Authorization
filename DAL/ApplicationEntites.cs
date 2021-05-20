using Model;
using System.Data.Entity;

namespace DAL
{
    public class ApplicationEntites : DbContext
    {
        public ApplicationEntites() : base("Minecraft") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<UserAndServer> UserAndServers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
