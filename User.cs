namespace tema.Directory;

public class User
{
    private string username, password, email;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }
    
    public string Getmail()
    {
        return email;
    }

    public void ChangePassword(string newPassword)
    {
        password = newPassword;
    }

    public override string ToString()
    {
        return username + " " + email;
    }
}