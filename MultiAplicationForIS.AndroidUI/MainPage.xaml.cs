using MultiAplicationForIS.BLForAPI;
using MultiAplicationForIS.Core.Interfaces;

namespace MultiAplicationForIS.AndroidUI
{
    public partial class MainPage : ContentPage
    {
        private readonly IUserService _IUserService;

        public MainPage()
        {
            InitializeComponent();
            _IUserService = new APIUserService(); // зависимость 
        }

       

        private void BtnAut_Clicked(object sender, EventArgs e)
        {
            try
            {
                var us =  _IUserService.GetUser(entryLogin.Text, entryPassword.Text);
                labelMessage.Text = "Привет " + us.Name;
            }
            catch (Exception ex)
            {

                labelMessage.Text = ex.Message;
            }
        }
    }
}