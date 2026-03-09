namespace Abuke_LongExercise1
{
    internal class Side : Item
    {
        private string type = "";
        private string size = "";
        private int cost = -1;

        public string Type 
        { 
            get => type;
            set => type = value;
        }
        public string Size 
        { 
            get => size; 
            set => size = value;
        }
        public override int Cost 
        { 
            get 
            {
                if (cost == -1)
                    calculateCost();
                return cost;
            } 
        }


        private void calculateCost() 
        {
            if (type == "Fries")
            {
                if (size == "Medium")
                    cost = 50;
                else if (size == "Large")
                    cost = 75;
                else
                    throw new ArgumentException("Invalid side size");
            }
            else if (type == "Onion Rings")
            {
                if (size == "Medium")
                    cost = 60;
                else if (size == "Large")
                    cost = 90;
                else
                    throw new ArgumentException("Invalid side size");
            }
            else if (type == "Bacon Chips")
            {
                if (size == "Medium")
                    cost = 70;
                else if (size == "Large")
                    cost = 105;
                else
                    throw new ArgumentException("Invalid side size");
            }
            else 
            {
                cost = -1;
                throw new ArgumentException("Invalid side type");
            }
        }

        public override string ToString()
        {
            return size + " " + type;
        }
    }
}
