using MultiAplicationForIS.Core.Interfaces;
using MultiAplicationForIS.Core.Model;

namespace MultiAplicationForIS.SQLDB.Services
{
    public class UserServices : IUserService
    {

        private MS_Context _context = new MS_Context();

        public void AddUser(string username, string password, string email)
        {
            try
            {
                Model.User user = new Model.User(); // бд 
                user.Email = email;
                user.Name = username;
                user.Password = password;
                _context.Users.Add(user);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("error db " + "\n" + ex.Message);
            }
        }

        public User GetUser(string email, string password)
        {
            try
            {
                var userDb = _context.Users.Single(x => x.Password == password
                && x.Email == email);

                if (userDb != null)
                    return new Core.Model.User(userDb.Id, userDb.Name,
                        userDb.Email, userDb.Password); // преобразование  пользователя
                else
                    throw new Exception("пользователь не найден");

            }
            catch (Exception ex)
            {
                throw new Exception("error db " + "\n" + ex.Message);
            }
        }
    }
}
