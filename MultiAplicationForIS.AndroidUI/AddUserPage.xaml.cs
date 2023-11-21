using Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific;
using MultiAplicationForIS.BLForAPI;
using MultiAplicationForIS.Core.Interfaces;

namespace MultiAplicationForIS.AndroidUI;

public partial class AddUserPage : ContentPage
{

    private readonly IUserService _IUserService;
    public AddUserPage(IUserService service)
	{
		InitializeComponent();
        _IUserService = service;
	}

    private async void BtnAddUser_Clicked(object sender, EventArgs e)
    {
        try
        {
            _IUserService.AddUser(entryName.Text, entryPassword.Text, entryLogin.Text);
            await DisplayAlert("Уведомление", "Пользователь добавлен в БД", "ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ошибка", ex.Message, "ok");
        }
    }
}