using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

/// <summary>
/// Carte qui donne 20$ au joueur (carte économique simple).
/// </summary>
public class Card_BonneGestion : Card
{
    public Card_BonneGestion() : base(
        name: "Le Bon Gestionnaire",
        description: "Gagne 20$ grâce à une bonne gestion.",
        rarity: CardRarity.Common,
        effect: new Effect_GainMoney(20)
    ) {}
}
