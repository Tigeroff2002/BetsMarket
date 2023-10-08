namespace Models;

/// <summary>
/// Представляет перечисление результатов ставки.
/// </summary>
public enum BetResult
{
    /// <summary>
    /// Исход ставки выиграл.
    /// </summary>
    Won,

    /// <summary>
    /// Исход ставки проиграл.
    /// </summary>
    Lost,

    /// <summary>
    /// Ставка отменена системой (возврат средств).
    /// </summary>
    Rejected
}
