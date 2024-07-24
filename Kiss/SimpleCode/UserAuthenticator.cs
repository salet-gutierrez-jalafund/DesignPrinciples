namespace KissSimple;

public class UserAuthenticator
{
    private readonly UserDataProvider _userDataProvider;

    public UserAuthenticator(UserDataProvider userDataProvider)
    {
        _userDataProvider = userDataProvider;
    }

    public bool IsValidUser(string username, string password)
    {
        var user = _userDataProvider.GetUserByUsername(username);
        return user != null && user.Password == password;
    }
}
