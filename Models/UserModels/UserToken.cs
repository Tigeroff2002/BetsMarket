namespace Models.UserModels;

/// <summary>
/// Представляет класс для описания токена.
/// </summary>
/// <param name="Token">
/// Токен пользователя.
/// </param>
public sealed record class UserToken(string Token);
