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
       

        private  async void BtnAut_Clicked(object sender, EventArgs e)
        {
            try
            {
                var us =  _IUserService.GetUser(entryLogin.Text, entryPassword.Text);
                await DisplayAlert("Уведомление", $"Привет {us.Name}", "ОK");
            }
            catch (Exception ex)
            {

                await DisplayAlert("Ошибка", ex.Message, "ОK");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            AddUserPage addUserPage = new AddUserPage(_IUserService);
            await Navigation.PushModalAsync(addUserPage);
        }
    }
}