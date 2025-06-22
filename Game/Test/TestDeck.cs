// Fichier : /Game/Test/TestDeck.cs

using System;
using System.Collections.Generic;
using StyleAndCook.Entities;
using StyleAndCook.Deck;

namespace StyleAndCook.Game.Test
{
    public static class TestDeck
    {
        public static void Executer()
        {
            // Création des joueurs (un joueur principal, un adversaire fictif)
            Player joueur = new Player("Toi");
            Player adversaire = new Player("Adversaire");

            // Création d'un deck
            DeckManager gestionDeck = new DeckManager();
            List<Card> deck = gestionDeck.GenererDeckParDefaut();

            // Mélange du deck
            deck = Shuffle(deck);

            Console.WriteLine("Deck mélangé. Début du test de pioche et d'effets...\n");

            // On pioche et joue 3 cartes
            for (int i = 0; i < 3 && i < deck.Count; i++)
            {
                Card carte = deck[i];
                Console.WriteLine($"👉 Carte piochée : {carte.Name} - {carte.Description}");

                // Application de l'effet de la carte
                carte.Effect.Apply(joueur, adversaire);

                Console.WriteLine($"💰 Argent : {joueur.Money} | 🌟 Réputation : {joueur.Reputation} | 🧠 Moralité : {joueur.Morality}");
                Console.WriteLine("------------------------------------------------------------------\n");
            }

            Console.WriteLine("✅ Test terminé !");
        }

        // Fonction pour mélanger le deck
        private static List<Card> Shuffle(List<Card> deck)
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (deck[k], deck[n]) = (deck[n], deck[k]);
            }
            return deck;
        }
    }
}
