namespace pvp1
{

    class GameRunner
    {
        static GameRunner()
        {
            Console.WriteLine("Game Starting..... ");
            Console.WriteLine("🥊 Welcome to the Fighting Game of Your Dreams! 🥊");
            Console.WriteLine("In this game, you'll choose your player and fight against the opponent.");
            Console.WriteLine("👊 There are three kinds of players available: 👊");
            Console.WriteLine("1. THE UNDERTAKER 🧟‍♂️: ");
            Console.WriteLine("   - Health: 150");
            Console.WriteLine("   - Damage to Opponent: 10-20");
            Console.WriteLine("   - Healing Factor: 10-15");
            Console.WriteLine("2. JOHN CENA 💪:");
            Console.WriteLine("   - Health: 50");
            Console.WriteLine("   - Damage to Opponent: 25-35");
            Console.WriteLine("   - Healing Factor: 20-30");
            Console.WriteLine("3. BROCK LESNAR 🤼:");
            Console.WriteLine("   - Health: 100");
            Console.WriteLine("   - Damage to Opponent: 20-25");
            Console.WriteLine("   - Healing Factor: 15-25");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PvP Battle Game!");

            Player player1 = ChoosePlayer.GetPlayer(1);
            Player player2 = ChoosePlayer.GetPlayer(2);

            Console.WriteLine($"Player 1: {player1.Name}, Health: {player1.Health}");
            Console.WriteLine($"Player 2: {player2.Name}, Health: {player2.Health}");
            Fight.StartBattle(player1, player2);

        }
    }

}