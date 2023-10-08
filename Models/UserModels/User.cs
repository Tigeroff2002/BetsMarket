namespace Models.UserModels;

/// <summary>
/// Представляет описание пользователя.
/// </summary>
public sealed class User
{
    public Id<User> Id { get; }

    public Name<User> Name { get; }

    public UserToken Token { get; }

    public string Email { get; }

    public string Password { get; }

    public string PhoneNumber { get; }

    public Limit Limit { get; }

    /// <summary>
    /// Создает экземпляр <see cref="User"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="token"></param>
    /// <param name="email"></param>
    /// <param name="password"></param>
    public User(
        Id<User> id,
        Name<User> name,
        UserToken token,
        string email,
        string password,
        string phoneNumber,
        Limit limit)
    {
        Id = id;
        Name = name;
        Token = token 
            ?? throw new ArgumentNullException(nameof(token));

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentNullException(nameof(email));
        }

        Email = email;

        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentNullException(nameof(password));
        }

        Password = password;

        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentNullException(nameof(phoneNumber));
        }

        PhoneNumber = phoneNumber;

        Limit = limit 
            ?? throw new ArgumentNullException(nameof(limit));
    }
}
