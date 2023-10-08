using Models.UserModels;

namespace Models;

/// <summary>
/// Представляет модель для ставки.
/// </summary>
public sealed class Bet
{
    public Id<Bet> Id { get; }

    public Name<Bet> Name { get; }

    public Id<Selection> SelectionId { get; }  

    public Id<User> UserId { get; }
    
    public AmountValue AmountValue { get; }

    public BetStatus Status { get; }

    public BetResult Result { get; }

    /// <summary>
    /// Создает экеземпляр <see cref="Bet"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="selectionId"></param>
    /// <param name="userId"></param>
    /// <param name="amountValue"></param>
    /// <param name="status"></param>
    /// <param name="result"></param>
    public Bet(
        Id<Bet> id,
        Name<Bet> name,
        Id<Selection> selectionId, 
        Id<User> userId,
        AmountValue amountValue,
        BetStatus status, 
        BetResult result)
    {
        Id = id;
        Name = name;
        SelectionId = selectionId;
        UserId = userId;
        AmountValue = amountValue;
        Status = status;
        Result = result;
    }
}
