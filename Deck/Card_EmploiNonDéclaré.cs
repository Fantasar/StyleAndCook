using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

/// <summary>
/// Permet de gagner 30$ au risque de perdre 10 points de moralité.
/// </summary>
public class Card_EmploiNonDéclaré : Card
{
    public Card_EmploiNonDéclaré() : base(
        name: "Emploi Non Déclaré",
        description: "Gagne 30$ illégalement. Risque moralité -10.",
        rarity: CardRarity.Epic,
        effect: new Effect_RiskyMoney(30, 10)
    ) {}
}
