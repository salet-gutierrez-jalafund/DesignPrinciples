namespace KissComplex;

public class UserDataProvider
{
    public User GetUserByUsername(string username)
    {
        if (username == "admin")
        {
            return new User("admin", "password123");
        }
        return null;
    }
}
