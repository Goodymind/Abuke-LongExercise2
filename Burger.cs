namespace Abuke_LongExercise1
{
    internal class Burger : Item
    {
        private int patties;
        private int cheese;
        private int totalCost = 50;
        private bool hasVeggies;

        public int Patties { get => patties;  }
        public int Cheese { get => cheese; }
        public override int Cost { get => totalCost; }
        public bool HasVeggies { get => hasVeggies; }

        public void addPatty(int pattyCount)
        {
            patties += pattyCount;
            totalCost += pattyCount * 50;
        }

        public void addCheese(int cheeseCount)
        {
            cheese += cheeseCount;
            totalCost += cheeseCount * 25;
        }

        public void addVeggies()
        {
            hasVeggies = true;
        }

        public override string ToString()
        {
            return "Burger with " + patties + " extra patties, " + cheese + " extra cheese, and " + (hasVeggies ? "veggies" : "no veggies");
        }
    }
}
