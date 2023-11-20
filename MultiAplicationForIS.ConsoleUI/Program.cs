

using MultiAplicationForIS.Core.Interfaces;

IUserService _service = GetService.GetUserService();



while (true)
{
    Start();
}

void Start()
{
    Console.WriteLine("Привет  я программа:");
    Console.WriteLine("Вот что  я  могу :");
    Console.WriteLine("Добавить пользователя: \"add\"");
    Console.WriteLine("Авторизоваться: \"logIn\"");
    Console.WriteLine("Введите команду:");
    switch (Console.ReadLine().Trim().ToLower())
    {
        case "add": AddUser(); break;
        case "login": LogIn(); break;
        default: Console.WriteLine("Я вас не понимаю - попробуйте еще раз");
            break;
    }
    Console.ReadLine();

}

void LogIn()
{
  Console.WriteLine("Авторизация");
  Console.WriteLine("Введите логин");
  string emeil = Console.ReadLine();
  Console.WriteLine("Введите  пароль");
  string pass = Console.ReadLine();

    try
    {
        var user = _service.GetUser(emeil, pass);
        Console.WriteLine($"Привет {user.Name}");

    }
    catch (Exception ex)
    {
       Console.WriteLine(ex.Message );
    }
}

void AddUser()
{
    Console.WriteLine("Регистрация");

    Console.WriteLine("Введите имя"); 
    string name = Console.ReadLine();

    Console.WriteLine("Введите почту");
    string emeil = Console.ReadLine();

   
    Console.WriteLine("Введите  пароль");
    string pass = Console.ReadLine();

    try
    {
         _service.AddUser( name , pass , emeil);
        Console.WriteLine("Пользователь добавлен");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}