namespace Abuke_LongExercise1
{
    internal class Wrap : Item
    {
        private bool allMeat;
        private int cheese;
        private string spiceLevel = "";
        private int cost = 100;

        public bool AllMeat { get => allMeat; }
        public int Cheese { get => cheese; }
        public string SpiceLevel { get => spiceLevel; }
        public override int Cost { get => cost; }
    
        public void AddCheese(int cheeseCount)
        {
            cheese += cheeseCount;
            cost += cheeseCount * 20;
        }

        public void SetSpiceLevel(string spiceLevel) 
        {
            this.spiceLevel = spiceLevel;
        }

        public void RemoveVeggies()
        {
            allMeat = true;
        }

        public override string ToString()
        {
            return allMeat ? "All Meat Wrap with " + cheese + " cheese and " + spiceLevel + " spice level" : "Wrap with veggies, " + cheese + " cheese and " + spiceLevel + " spice level";
        }

    }
}
