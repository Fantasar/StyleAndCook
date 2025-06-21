using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

/// <summary>
/// Fait perdre de la réputation à l’adversaire.
/// </summary>
public class Card_ContrôleSanitaire : Card
{
    public Card_ContrôleSanitaire() : base(
        "Contrôle Sanitaire",
        "L'adversaire perd 15% de réputation.",
        CardRarity.Rare,
        new Effect_LoseReputation(15)
    ) {}
}
