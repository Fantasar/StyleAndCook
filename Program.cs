using StyleAndCook.Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenue dans Style&Cook 🍽️");

        Player joueur = new Player("Alice");
        Console.WriteLine($"Joueur : {joueur.Nom}, Argent : {joueur.Argent}$");
    }
}
