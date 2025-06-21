using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

/// <summary>
/// Augmente la réputation du joueur de 10 points.
/// </summary>
public class Card_PromoFlyers : Card
{
    public Card_PromoFlyers() : base(
        name: "Promo Flyers",
        description: "Distribuez des flyers dans la rue : gagne +10 en réputation.",
        rarity: CardRarity.Common,
        effect: new Effect_GainReputation(10)
    ) {}
}
