namespace tic_tac_toe
{
    internal static class Starter
    {
        public static void Run()
        {
            Console.WriteLine("Hello! It's game tic-tac-toe.\n");
            //string name = Console.ReadLine();               // add data validation
            //Player player1 = new Player(name);
            //Console.WriteLine("Enter name of Player 2");
            //name = Console.ReadLine();                      // add data validation
            //Player player2 = new Player(name);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write("   |");
            //    }
            //    Console.WriteLine();
            //}
            Field field = new Field();
            field.Template();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Turn Player 1. Enter coordinates (1-3)");
                int x = int.Parse(Console.ReadLine())-1;
                int y = int.Parse(Console.ReadLine())-1;
                field.AddX(x, y);
                field.ShowField();
                if (!field.Win())
                    break;
                Console.WriteLine("Turn Player 2. Enter coordinates (1-3)");
                x = int.Parse(Console.ReadLine())-1;
                y = int.Parse(Console.ReadLine())-1;
                field.AddO(x, y);
                field.ShowField();
                if (!field.Win())
                    break;

            }

        }
    }
}
