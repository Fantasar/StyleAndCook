using System;
using System.Collections.Generic;
using StyleAndCook.Entities;
using StyleAndCook.Deck;

namespace StyleAndCook.Game
{
    // Cette classe gère le deck d'un joueur : pioche, mélange, main, etc.
    public class DeckManager
    {
        // Liste des cartes disponibles dans le deck (pioche)
        private List<Card> deck;

        // Cartes actuellement dans la main du joueur
        private List<Card> main;

        // Nombre de cartes maximum dans la main
        private const int TAILLE_MAIN = 3;

        // Constructeur : on initialise un deck vide pour le moment
        public DeckManager()
        {
            deck = new List<Card>();
            main = new List<Card>();
        }

        // Initialise le deck avec une sélection de cartes prédéfinies
        public void InitialiserDeck()
        {
            // Exemple : deck de base avec 10 cartes
            deck.Add(DefaultCards.CreerCarteEmploiNonDéclaré());
            deck.Add(DefaultCards.CreerCarteControleSanitaire());
            deck.Add(DefaultCards.CreerCarteHeuresSup());
            deck.Add(DefaultCards.CreerCarteBonneGestion());
            deck.Add(DefaultCards.CreerCartePromoFlyers());

            MelangerDeck();
        }

        // Mélange le deck de façon aléatoire
        public void MelangerDeck()
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var valeurTemp = deck[k];
                deck[k] = deck[n];
                deck[n] = valeurTemp;
            }
        }

        // Pioche une ou plusieurs cartes et les ajoute à la main du joueur
        public void PiocherCartes(int nombre)
        {
            for (int i = 0; i < nombre; i++)
            {
                if (deck.Count == 0)
                {
                    Console.WriteLine("Le deck est vide, impossible de piocher.");
                    break;
                }

                if (main.Count >= TAILLE_MAIN)
                {
                    Console.WriteLine("Main pleine !");
                    break;
                }

                Card piochee = deck[0];
                deck.RemoveAt(0);
                main.Add(piochee);
                Console.WriteLine($"Carte piochée : {piochee.Name} - {piochee.Description}");
            }
        }

        // Affiche les cartes actuelles dans la main
        public void AfficherMain()
        {
            Console.WriteLine("\n🃏 Cartes en main :");
            foreach (var carte in main)
            {
                Console.WriteLine($"- {carte.Name} ({carte.Description})");
            }
        }
    }
}
