using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

/// <summary>
/// Double les revenus du joueur pendant 2 tours.
/// </summary>
public class Card_HeuresSup : Card
{
    public Card_HeuresSup() : base(
        name: "Heures Sup",
        description: "Double les revenus pendant 2 tours.",
        rarity: CardRarity.Uncommon,
        effect: new Effect_TemporaryIncomeBoost(2)
    ){}
}
