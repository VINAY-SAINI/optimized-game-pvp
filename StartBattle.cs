namespace pvp1
{
    class Fight
    {
        public static void StartBattle(Player player1, Player player2)
        {
            while (player1.Health > 0 && player2.Health > 0)
            {
                TakeTurn(player1, player2);
                TakeTurn(player2, player1);
            }

            Console.WriteLine("Game Over");
        }
        static void TakeTurn(Player attacker, Player target)
        {
            Console.WriteLine($"{attacker.Name}'s turn:");
            Console.WriteLine("1. Heal");
            Console.WriteLine("2. Attack");

            int choice = GetValidInput();
            switch (choice)
            {
                case 1:
                    attacker.Healing();
                    break;
                case 2:
                    attacker.Attack(target);
                    break;
            }
        }
        static int GetValidInput()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid input. Please enter between 1 and 2.");
            }
            return choice;
        }
    }

}