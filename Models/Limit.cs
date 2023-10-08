namespace Models;

/// <summary>
/// Представляет модель ограничения суммы ставки c описанием.
/// </summary>
/// <param name="Value">
/// Значение платежного ограничения.
/// </param>
/// <param name="currency">
/// Тип платежной валюты.
/// </param>
/// <param name="Description">
/// Описание данного ограничения.
/// </param>
public record class Limit(
    long Value, 
    Currency currency,
    string Description);
