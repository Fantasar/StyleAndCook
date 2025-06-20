using System;
using StyleAndCook.Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenue dans Style&Cook ");

        Player joueur = new Player("Alice");
        Deck deck = new Deck();

        Console.WriteLine($"Joueur : {joueur.Nom}, Argent : {joueur.Argent}$");
        Console.WriteLine();

        for (int tour = 1; tour <= 3; tour++) // 3 tours de jeu
        {
            Console.WriteLine($"🔁 Tour {tour}:");

            Card carte = deck.TirerCarte();
            Console.WriteLine($"Carte tirée : {carte.Nom} - {carte.Description}");

            carte.AppliquerEffet(joueur);

            Console.WriteLine($"Argent actuel : {joueur.Argent}$");
            Console.WriteLine();
        }

        Console.WriteLine("🎉 Fin de partie !");
        Console.WriteLine($"Argent final : {joueur.Argent}$");
    }
}