namespace Models;

/// <summary>
/// Представляет модель значения 
/// некоторой численного величины.
/// </summary>
/// <typeparam name="TEntity">
/// Тип сущности.
/// </typeparam>
/// <param name="Value">
/// Значение величины.
/// </param>
public record struct EntityValue<TEntity>(decimal Value);
