using StyleAndCook.Entities;

namespace StyleAndCook.Entities.Effects;

public class Effect_GainMoney : CardEffect
{
    public int Amount { get; }

    public Effect_GainMoney(int amount) : base("Gain d'argent")
    {
        Amount = amount;
    }

    public override void Apply(Player source, Player target)
    {
        source.Money += Amount;
        Console.WriteLine($"{source.Name} gagne {Amount} 💵 !");
    }
}