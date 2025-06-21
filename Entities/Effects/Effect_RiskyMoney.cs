using StyleAndCook.Entities;

namespace StyleAndCook.Entities.Effects;
public class Effect_RiskyMoney : CardEffect
{
    public int Amount { get; }
    public int MoralityPenalty { get; }

    public Effect_RiskyMoney(int amount, int moralityPenalty) : base("Argent sale")
    {
        Amount = amount;
        MoralityPenalty = moralityPenalty;
    }

    public override void Apply(Player source, Player target)
    {
        source.Money += Amount;
        source.Morality -= MoralityPenalty;
        Console.WriteLine($"{source.Name} gagne {Amount}$ illégalement mais perd {MoralityPenalty} moralité ⚠️");
    }
}