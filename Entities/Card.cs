namespace StyleAndCook.Game
{
    public class Card
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public int EffetArgent { get; set; }

        public Card(string nom, string description, int effetArgent)
        {
            Nom = nom;
            Description = description;
            EffetArgent = effetArgent;
        }

        public void AppliquerEffet(Player joueur)
        {
            joueur.Argent += EffetArgent;
            Console.WriteLine($"{Nom} appliqué à {joueur.Nom} : {EffetArgent} $");
        }
    }
}