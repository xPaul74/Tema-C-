namespace tema.Directory;

public class MobileApplication : Application
{
    private double rating;
    public MobileApplication(string AppName, int MaxUsers, List<User> users) : base(AppName, MaxUsers, users) {}

    public double RateApp()
    {
        int nr_of_users = users.Count;
        for (int i = 0; i < nr_of_users; i++)
        {
            Console.WriteLine($"Ratingul utilizatorului {i+1}: ");
            rating += Convert.ToDouble(Console.ReadLine());
        }

        return rating /= nr_of_users;
    }
}