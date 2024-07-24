namespace KissComplex;

public class UserAuthenticator
{
    private readonly UserDataProvider _userDataProvider;

    public UserAuthenticator(UserDataProvider userDataProvider)
    {
        _userDataProvider = userDataProvider;
    }

    public bool IsValidUser(string username, string password)
    {
        if (username == null || password == null)
        {
            return false;
        }
        if (username.Length < 5 || password.Length < 5)
        {
            return false;
        }
        var user = _userDataProvider.GetUserByUsername(username);
        if (user == null)
        {
            return false;
        }
        return user.Password == password;
    }
}
