using Microsoft.Win32.SafeHandles;

namespace tema.Directory;

public class Admin
{
    private string name;
    private List<Application> applications = new List<Application>();
    public Admin(string name, List<Application> applications)
    {
        this.name = name;
        this.applications = applications;
    }

    public void AddUser(User user, Application app)
    {
        app.AddUser(user);
    }

    public void RemoveUser(User user, Application app)
    {
        app.RemoveUser(user);
    }
}