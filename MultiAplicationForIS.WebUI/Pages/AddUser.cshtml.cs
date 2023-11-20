using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MultiAplicationForIS.BLForAPI;
using MultiAplicationForIS.Core.Interfaces;

namespace MultiAplicationForIS.WebUI.Pages
{
    public class AddUserModel : PageModel
    {

        private readonly IUserService _IUserService;
        private readonly ILogger<IndexModel> _logger;

        public string Message { get; private set; }
        public AddUserModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _IUserService = new APIUserService();
        }


        public void OnPostAddUser(string name , string login, string password)
        {
            try
            {
                _IUserService.AddUser(name, password, login);
                Message = "Done";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}
