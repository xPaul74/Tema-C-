using System.Reflection.Metadata;

namespace tema.Directory;

public class WebApplication : Application
{
    public WebApplication(string AppName, int MaxUsers, List<User> users) : base(AppName, MaxUsers, users) {}

    void HttpRequest(User user)
    {
        if (users.Contains(user))
            Console.WriteLine("Ok Request");
        else 
            Console.WriteLine("Bad Request");
    }
}