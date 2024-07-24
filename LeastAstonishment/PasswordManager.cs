namespace LeastAstonishment;

public class PasswordManager
{
    public void UpdatePassword(User user, string newPassword)
    {
        if (string.IsNullOrWhiteSpace(newPassword))
        {
            throw new ArgumentException("New password cannot be empty.");
        }

        user.Password = newPassword;
    }
}
