namespace Models;

/// <summary>
/// Представляет модель для рынка.
/// </summary>
public sealed class Market
{
    public Id<Market> Id { get; }

    public Name<Market> Name { get; }

    public MarketType Type { get; }

    /// <summary>
    /// Создает экземпляр <see cref="Market"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="type"></param>
    public Market(
        Id<Market> id,
        Name<Market> name, 
        MarketType type)
    {
        Id = id;
        Name = name;
        Type = type;
    }
}
