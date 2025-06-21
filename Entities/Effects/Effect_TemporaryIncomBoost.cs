using StyleAndCook.Entities;

namespace StyleAndCook.Entities.Effects;
public class Effect_TemporaryIncomeBoost : CardEffect
{
    public int Turns { get; }

    public Effect_TemporaryIncomeBoost(int turns) : base("Boost temporaire")
    {
        Turns = turns;
    }

    public override void Apply(Player source, Player target)
    {
        source.AddTemporaryBuff("IncomeBoost", Turns);
        Console.WriteLine($"{source.Name} booste ses revenus pour {Turns} tours !");
    }
}