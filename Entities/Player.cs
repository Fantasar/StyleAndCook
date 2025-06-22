namespace StyleAndCook.Entities;

public class Player
{
    public string Name { get; set; }
    public Restaurant Restaurant { get; set; }
    public int Money { get; set; }
    public int Reputation { get; set; }
    public List<Card> Hand { get; set; }

    public int Morality { get; set; } = 100; // ou une autre valeur de départ    
    public Player(string name, Restaurant restaurant)
    {
        Name = name;
        Restaurant = restaurant;
        Money = 0;
        Reputation = 0;
        Hand = new List<Card>();
    }

    public void PlayCard(Card card, Player opponent)
    {
        card.Activate(this, opponent);
        Hand.Remove(card);
    }
}