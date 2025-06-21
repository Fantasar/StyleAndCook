using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

/// <summary>
/// Fait perdre de la réputation à l’adversaire.
/// </summary>
public class Card_ContrôleSanitaire : Card
{
    public Card_ContrôleSanitaire() : base(
        name: "Contrôle Sanitaire",
        description: "L'adversaire perd 15% de réputation.",
        rarity: CardRarity.Rare,
        effect: new Effect_LoseReputation(15)
    ) {}
}
