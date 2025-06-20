namespace StyleAndCook.Entities;

public abstract class CardEffect
{
    public string EffectName { get; set; }

    protected CardEffect(string name)
    {
        EffectName = name;
    }

    public abstract void Apply(Player source, Player target);
}