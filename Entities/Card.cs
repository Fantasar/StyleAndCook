namespace StyleAndCook.Entities;

public enum CardRarity { Common, Rare, Epic, Legendary }

public class Card
{
    public string Name { get; set; }
    public string Description { get; set; }
    public CardRarity Rarity { get; set; }
    public CardEffect Effect { get; set; }

    public Card(string name, string description, CardRarity rarity, CardEffect effect)
    {
        Name = name;
        Description = description;
        Rarity = rarity;
        Effect = effect;
    }

    public void Activate(Player source, Player target)
    {
        Effect?.Apply(source, target);
    }
}