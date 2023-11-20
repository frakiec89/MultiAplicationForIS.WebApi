using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAplicationForIS.Core.Interfaces
{
    public interface IUserService
    {
        void AddUser (string username, string password , string email) ;
        /// <summary>
        /// Получить пользователя  по емеил  и  паролю
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Model.User GetUser (string email , string password);
    }
}
