using StyleAndCook.Entities;
using StyleAndCook.Entities.Effects;

namespace StyleAndCook.Deck;

public static class DefaultCards
{
    public static Card CreateGainMoneyCard()
    {
        return new Card(
            name: "Le Bon Gestionnaire",
            description: "Gagne 20$ grâce à une bonne gestion.",
            rarity: CardRarity.Common,
            effect: new Effect_GainMoney(20)
        );
    }
    public static Card CreateSanitaryControlCard()
    {
        return new Card(
            "Contrôle Sanitaire",
            "L'adversaire perd 15% de réputation.",
            CardRarity.Rare,
            new Effect_LoseReputation(15)
        );
    }

    public static Card CreateOvertimeCard()
    {
        return new Card(
            "Heures Sup",
            "Double les revenus pendant 2 tours.",
            CardRarity.Uncommon,
            new Effect_TemporaryIncomeBoost(2)
        );
    }

    public static Card CreateIllegalWorkerCard()
    {
        return new Card(
        "Emploi Non Déclaré",
        "Gagne 30$ illégalement. Risque moralité -10.",
        CardRarity.Epic,
        new Effect_RiskyMoney(30, 10)
    );

    }
    public static Card CreateFlyerPromoCard()
{
    return new Card(
        "Promo Flyers",
        "Gagne +10 en réputation.",
        CardRarity.Common,
        new Effect_GainReputation(10)
    );
}
}