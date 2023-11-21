using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MultiAplicationForIS.BLForAPI;
using MultiAplicationForIS.Core.Interfaces;

namespace MultiAplicationForIS.WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserService _IUserService;

        public string Message { get; private set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _IUserService = new APIUserService(); // todo  плохо  
        }

        public void OnGet()
        {
           
        }
        public void OnPostLogIn(string login, string password)
        {
            try
            {
               var us =   _IUserService.GetUser(login, password);
                if (us != null)
                {
                    Message = "Привет " + us.Name; 
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }


        }



    }
}