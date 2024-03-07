namespace pvp1
{
    class ChoosePlayer
    {
        public static Player GetPlayer(int playerNumber)
        {
            Console.WriteLine($"Player {playerNumber}: Choose your player:");
            Console.WriteLine("1. The Undertaker (High Health, Low Damage, Low Healing)");
            Console.WriteLine("2. John Cena (Avg Health, Avg Damage, Avg Healing)");
            Console.WriteLine("3. Brock Lesnar (Low Health, High Damage, Avg Healing)");

            int choice = GetValidInput();
            switch (choice)
            {
                case 1:
                    return new UnderTaker();
                case 2:
                    return new JohnCena();
                case 3:
                    return new BrockLesnar();
            }
            return new UnderTaker();
        }
        static int GetValidInput()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2 && choice != 3))
            {
                Console.WriteLine("Invalid input. Please enter between 1 and 3.");
            }
            return choice;
        }

    }
}