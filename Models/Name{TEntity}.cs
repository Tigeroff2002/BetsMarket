namespace Models;

/// <summary>
/// Модель описания имени сущности.
/// </summary>
/// <typeparam name="TEntity">
/// Тип сущности.
/// </typeparam>
/// <param name="Value">
/// Значение имени.
/// </param>
public record class Name<TEntity>
    where TEntity : class
{
    public string Value { get; }

    /// <summary>
    /// Создает экземпляр <see cref="Name{TEntity}"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается в случае
    /// </exception>
    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(nameof(value));
        }

        Value = value;
    }
}
