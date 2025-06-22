using StyleAndCook.Entities;
using System.Collections.Generic;
using StyleAndCook.Deck;
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
            new Card_EmploiNonDéclaré(),
            new Card_ControleSanitaire(),
            new Card_HeuresSup(),
            new Card_BonneGestion(),
            new Card_PromoFlyers()
        };
    }
}
