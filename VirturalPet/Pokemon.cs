
namespace VirturalPet
{
    public class Arcanine
    {
        private int _hunger;
        private int _cleanliness;
        private int _happiness;

        public Arcanine(int hunger = 20, int cleanliness = 40, int happiness = 30)
        {
            _hunger = hunger;
            _cleanliness = cleanliness;
            _happiness = happiness;
        }

       
        public void ShowArcanine()
        {
            Console.Clear();
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Arcanine");
            Console.ForegroundColor = originalColor;
            Console.WriteLine($" Hunger: {_hunger}");
            Console.WriteLine($" Cleanliness: {_cleanliness}");
            Console.WriteLine($" Happiness: {_happiness}");
        }

        public void FeedArcanine()
        {
            Console.Clear();
            Console.WriteLine("You gave Arcanine his favourite food!");
            Console.WriteLine("Arcanine is such a messy eater!");
            _hunger += 50;
            _cleanliness -= 15;
            _happiness -= 5;
            Thread.Sleep(1000);
        }

        public void CleanArcanine()
        {
            Console.Clear();
            Console.WriteLine("You gave Arcanine a bath!");
            Console.WriteLine("Arcanine hates bathing time :(");
            _hunger -= 10;
            _cleanliness += 50;
            _happiness -= 30;
            Thread.Sleep(1000);
        }

        public void PetArcanine()
        {
            Console.Clear();
            Console.WriteLine("You pet and play with Arcanine!");
            Console.WriteLine("Arcanine loves the attention!");
            _hunger -= 15;
            _cleanliness -= 10;
            _happiness += 50;
            Thread.Sleep(1000);
        }

        public void ReduceAll()
        {
            _cleanliness -= 4;
            _happiness -= 3;
            _hunger -= 6;
        }

        public static Arcanine LoadArcanine()
        {
            var arcanine = new Arcanine();
            return arcanine;
        }

    }
}
