using StyleAndCook.Entities;

namespace StyleAndCook.Game;

public class GameManager
{
    public Player Player1 { get; private set; }
    public Player Player2 { get; private set; }

    private int turnCount = 0;

    public GameManager(Player p1, Player p2)
    {
        Player1 = p1;
        Player2 = p2;
    }

    public void StartGame()
    {
        Console.WriteLine("🔪 Nouvelle partie !");
        while (!IsGameOver())
        {
            RunTurn();
        }

        Console.WriteLine("🎉 Partie terminée !");
    }

    private void RunTurn()
    {
        turnCount++;
        Console.WriteLine($"--- Tour {turnCount} ---");
        // logique de tour
    }

    private bool IsGameOver()
    {
        return Player1.Money >= 100 || Player2.Money >= 100;
    }
}