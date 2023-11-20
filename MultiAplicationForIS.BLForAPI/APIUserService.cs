using MultiAplicationForIS.BLForAPI.ModelApi;
using MultiAplicationForIS.Core.Interfaces;
using MultiAplicationForIS.Core.Model;
using Newtonsoft.Json;


namespace MultiAplicationForIS.BLForAPI
{
    public class APIUserService : IUserService
    {

        private readonly string host = "https://localhost:7257";

        public void AddUser(string username, string password, string email)
        {
            string url = host + "/api/Registration/Registration";
            var userRequst = new UserRegistrationRequst() { Email = email , Name = username , Password = password};
            var userRequstJson = JsonConvert.SerializeObject(userRequst);

            try
            {
                string otvet = APIService.Post(url, userRequstJson);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUser(string email, string password)
        {
            string url = host + "/api/Authorization";
            var userRequst = new UserAuthorizationRequst() {  Emeil = email, Password = password };
            var userRequstJson = JsonConvert.SerializeObject(userRequst);

            try
            {
                string otvet = APIService.Post(url, userRequstJson);
                UserRespons respons = JsonConvert.DeserializeObject<UserRespons>(otvet);
                if (respons != null)
                    return new User(respons.Id, respons.Name, respons.Email, respons.Password);
                else
                    throw new Exception(otvet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
