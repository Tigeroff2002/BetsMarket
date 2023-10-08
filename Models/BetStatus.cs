namespace Models;

/// <summary>
/// Представляет перечисление статусов ставки.
/// </summary>
public enum BetStatus
{
    /// <summary>
    /// Статус заключения ставки.
    /// </summary>
    Pending,

    /// <summary>
    /// Статус принятия ставки после оплаты.
    /// </summary>
    Accepted,

    /// <summary>
    /// Статус отмены ставки CWT.
    /// </summary>
    Denied,

    /// <summary>
    /// Статус ставки после принятия в Live.
    /// </summary>
    Active,

    /// <summary>
    /// Статус ставки после завершения "игры" исхода.
    /// </summary>
    Finsihed
}
