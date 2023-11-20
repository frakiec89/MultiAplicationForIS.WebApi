using Microsoft.EntityFrameworkCore;

namespace MultiAplicationForIS.SQLDB
{
    internal class MS_Context : DbContext   
    {
        private string _login = "stud";
        private string _password = "stud";
        private string _server = "192.168.59.40";
        private string _database = "Ahtyamov_For_Is_20_11_v1";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnect());
        }
        public DbSet<Model.User> Users { get; set; } // db user 
        private string GetConnect ()
        {
            return $"server={_server}; database={_database};" +
                $"user id={_login};password={_password};TrustServerCertificate=true";
        }
    }
}