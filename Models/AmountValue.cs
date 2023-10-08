namespace Models;

/// <summary>
/// Представляет модель суммы платежа.
/// </summary>
/// <param name="Value">
/// Величина платежа (в условных единах валюты).
/// </param>
/// <param name="Currency">
/// Тип валюты.
/// </param>
public record struct AmountValue(
    EntityValue<AmountValue> Value,
    Currency Currency);
