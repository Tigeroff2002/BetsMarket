namespace Models;

/// <summary>
/// Представляет модель пары коэффициентов
/// исхода для каждой команды.
/// </summary>
public sealed record class OddsValuesPair
{
    /// <summary>
    /// Коэффициент исхода для домашней команды.
    /// </summary>
    public EntityValue<OddsValuesPair> HomeTeamOdd { get; }

    /// <summary>
    /// Коэффициент исхода для гостевой команды.
    /// </summary>
    public EntityValue<OddsValuesPair> AwayTeamOdd { get; }

    /// <summary>
    /// Создает экземпляр <see cref="OddsValuesPair"/>.
    /// </summary>
    /// <param name="homeTeamOdd"></param>
    /// <param name="awayTeamOdd"></param>
    public OddsValuesPair(
        EntityValue<OddsValuesPair> homeTeamOdd,
        EntityValue<OddsValuesPair> awayTeamOdd)
    {
        HomeTeamOdd = homeTeamOdd;
        AwayTeamOdd = awayTeamOdd;
    }
}
