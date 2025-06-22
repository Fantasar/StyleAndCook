using System;
using StyleAndCook.Entities; // 🔹 Ce using est crucial pour accéder à Player et CardEffect

namespace StyleAndCook.Entities.Effects
{
    public class Effect_GainReputation : CardEffect
    {
        public int Amount { get; }

        public Effect_GainReputation(int amount) : base("Gagne réputation")
        {
            Amount = amount;
        }   

        public override void Apply(Player source, Player target)
        {
            source.Reputation += Amount;
            Console.WriteLine($"{source.Name} gagne {Amount} points de réputation grâce à une promo flyer !");
        }
    }
}