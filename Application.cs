using System.IO.Pipes;

namespace tema.Directory;

public abstract class Application
{
    private string AppName;
    private int MaxUsers;
    protected List<User> users = new List<User>{};
    

    public Application(string AppName, int MaxUsers, List<User> users)
    {
        this.AppName = AppName; 
        this.MaxUsers = MaxUsers;
        this.users = new List<User>(users);
    }
    
    public string GetName()
    {
        return AppName;
    }

    public int GetNumberOfUsers()
    {
        return users.Count;
    }
    
    public override string ToString()
    {
        return AppName + " " + users.Count;
    }
    
    public void AddUser(User user)
    {
        if (GetNumberOfUsers() < MaxUsers)
            users.Add(user);
        else
            Console.WriteLine("Numar maxim de utilizatori depasit!!");
    }
    
    public void RemoveUser(User user)
    {
        if (users.Contains(user))
            users.Remove(user);
        else
            Console.WriteLine("Utilizator inexistent!");
    }
}