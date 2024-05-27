namespace VirturalPet
{
    internal class Program
    {
        static Arcanine arcanine = Arcanine.LoadArcanine(); // Feil var her: static Arcanine.arcanine = Arcanine.LoadArcanine();
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Menu();
                arcanine.ReduceAll();
                Game();
                Thread.Sleep(2000);
            }
            
        }

        static void Game()
        {
            char MenuChoice = Console.ReadKey().KeyChar;

            switch (MenuChoice)
            {
                case '1':
                    arcanine.FeedArcanine();
                    break;
                case '2':
                    arcanine.CleanArcanine();
                    break;
                case '3':
                    arcanine.PetArcanine();
                    break;
                case '4':
                    if (Console.ReadKey().KeyChar == '4')
                    {
                        Environment.Exit(69);
                    }

                    break;
            }
        }


        static void Menu()
        {
            arcanine.ShowArcanine();
            Console.WriteLine();
            Console.WriteLine("1. Feed Arcanine");
            Console.WriteLine("2. Clean Arcanine");
            Console.WriteLine("3. Pet Arcanine");
            Console.WriteLine("44. Exit App");
        }





    }
}
