namespace Models;

/// <summary>
/// Представляет тип рынка.
/// </summary>
public enum MarketType
{
    /// <summary>
    /// Тип рынка - победа 1 или 2 команды.
    /// </summary>
    OneXTwo,

    /// <summary>
    /// Тип рынка - тотал по счету матча.
    /// </summary>
    Total,

    /// <summary>
    /// Тип рынка - фора по счету матча.
    /// </summary>
    Handicap
}
