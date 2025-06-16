namespace StyleAndCook.Game
{
    public class Player
    {
        public string Nom { get; private set; }
        public int Argent { get; set; }

        public Player(string nom)
        {
            Nom = nom;
            Argent = 100; // Valeur par défaut
        }
    }
}
