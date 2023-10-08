namespace Models;

/// <summary>
/// Представляет описание абстрактного идентификатора.
/// </summary>
/// <typeparam name="TEntity">
/// Тип значения.
/// </typeparam>
/// <param name="Value">
/// Значение идентификатора.
/// </param>
public record struct Id<TEntity>(long Value);
