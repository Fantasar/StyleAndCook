using StyleAndCook.Entities;

namespace StyleAndCook.Entities.Effects;

public class Effect_LoseReputation : CardEffect
{
    public int Percent { get; }

    public Effect_LoseReputation(int percent) : base("Perte de réputation")
    {
        Percent = percent;
    }

    public override void Apply(Player source, Player target)
    {
        int loss = target.Reputation * Percent / 100;
        target.Reputation -= loss;
        Console.WriteLine($"{target.Name} perd {loss} points de réputation à cause du contrôle sanitaire !");
    }
}