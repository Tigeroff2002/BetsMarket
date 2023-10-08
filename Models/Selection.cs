namespace Models;

/// <summary>
/// Представляет модель описания исхода
/// некоторого события с рынком и парой коэффициентов.
/// </summary>
public sealed class Selection
{
    public Id<Selection> Id { get; }

    public Name<Selection> Name { get; }

    public Id<Market> MarketId { get; }

    public OddsValuesPair OddsValues { get; }

    public SelectionResult Result { get; }

    /// <summary>
    /// Создает экземпляр <see cref="Selection"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="marketId"></param>
    /// <param name="oddsValues"></param>
    /// <param name="result"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public Selection(
        Id<Selection> id,
        Name<Selection> name,
        Id<Market> marketId,
        OddsValuesPair oddsValues, 
        SelectionResult result)
    {
        Id = id;
        Name = name;
        MarketId = marketId;
        OddsValues = oddsValues 
            ?? throw new ArgumentNullException(nameof(oddsValues));
        Result = result;
    }
}
