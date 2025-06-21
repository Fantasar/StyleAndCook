using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

/// <summary>
/// Augmente la réputation du joueur de 10 points.
/// </summary>
public class Card_PromoFlyers : Card
{
    public Card_PromoFlyers() : base(
        "Promo Flyers",
        "Distribuez des flyers dans la rue : gagne +10 en réputation.",
        CardRarity.Common,
        new Effect_GainReputation(10)
    ) {}
}
