using StyleAndCook.Entities;

namespace StyleAndCook.Deck;

/// <summary>
/// Cette classe permet de regrouper toutes les cartes du jeu
/// dans une liste afin de les utiliser pour créer des decks.
/// </summary>
public static class DefaultCards
{
    /// <summary>
    /// Retourne toutes les cartes jouables par défaut.
    /// </summary>
    public static List<Card> GetAllCards()
    {
        return new List<Card>
        {
            /// <Malus> : Carte qui peut être jouée par l'adversaire pour nuire au joueur.
            new Card_EmploiNonDéclaré(),
            new Card_ContrôleSanitaire(),
            /// <Bonus> : Carte qui donne un avantage au joueur.
            new Card_HeuresSup(),
            new Card_BonneGestion(),
            new Card_PromoFlyers()
        };
    }
}
