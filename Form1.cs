
using Abuke_LongExercise1;
namespace Abuke_LongExercise2
{
    public partial class Form1 : Form
    {
        private int totalPrice;
        private int TotalPrice {
            get { return totalPrice;  }
            set { 
                totalPrice = value; 
                totalPriceLabel.Text = "Total Price " + totalPrice + " PHP";
            }
        }


        public Form1()
        {
            InitializeComponent();
        }
        enum OrderItemE { Burger, Wrap, Side, None }
        OrderItemE current = OrderItemE.None;

        private void addBurger_Click(object sender, EventArgs e)
        {
            sidePanel.Visible = false;
            wrapPanel.Visible = false;
            burgerPanel.Visible = true;
            createDummyBurger();
            current = OrderItemE.Burger;
        }

        private void addSide_Click(object sender, EventArgs e)
        {
            burgerPanel.Visible = false;
            sidePanel.Visible = true;
            wrapPanel.Visible = false;
            createDummySide();
            current = OrderItemE.Side;
        }

        private void addWrap_Click(object sender, EventArgs e)
        {
            burgerPanel.Visible = false;
            sidePanel.Visible = false;
            wrapPanel.Visible = true;
            current = OrderItemE.Wrap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current == OrderItemE.Burger)
            {
                addNewBurger();
            }
            else if (current == OrderItemE.Side)
            {
                addNewSide();
            }
            else if (current == OrderItemE.Wrap) 
            {
                addNewWrap();
            }
        }

        private void addNewBurger() {
            int extraPatties = (int) extraPattiesNumericUpDown.Value;
            int extraCheese = (int)extraCheeseNumericUpDown.Value;
            bool hasVeggies = burgerVeggies.Checked;
            Burger burger = new Burger();
            burger.addPatty(extraPatties);
            burger.addCheese(extraCheese);
            if (hasVeggies) burger.addVeggies();

            OrderItem burgerItem = new OrderItem();
            burgerItem.Item = burger;
            burgerItem.removeOrderItem += removeOrderItem;
            orderList.Controls.Add(burgerItem);
            TotalPrice += burger.Cost;        
        }

        private void addNewSide() {
            var typeRadio = sideTypes.Controls.OfType<RadioButton>()
                                            .FirstOrDefault(r => r.Checked);
            var sizeRadio = sideSize.Controls.OfType<RadioButton>()
                                           .FirstOrDefault(r => r.Checked);

            string type = typeRadio is not null ? typeRadio.Text : "None";
            string size = sizeRadio is not null ? sizeRadio.Text : "None";

            if (type == "None" || size == "None") 
                return;

            var side = new Side();
            side.Type = type;
            side.Size = size;
            TotalPrice += side.Cost;

            OrderItem sideItem = new OrderItem();
            sideItem.Item = side;
            sideItem.removeOrderItem += removeOrderItem;
            orderList.Controls.Add(sideItem);
        }

        private void addNewWrap() { 
            
        }

        private void removeOrderItem(object? sender, EventArgs e)
        {
            if (sender is OrderItem item) 
            {
                TotalPrice -= item.Item.Cost;
                orderList.Controls.Remove(item);
                item.Dispose();
            }
        }

        // Function to display current selected side cost
        private void sideSizeTypeSelected(object? sender, EventArgs e) 
        {
            createDummySide();
        }

        private void burgerSelected(object? sender, EventArgs e) 
        {
            createDummyBurger();
        }

        private void createDummyBurger()
        {
            int extraPatties = (int)extraPattiesNumericUpDown.Value;
            int extraCheese = (int)extraCheeseNumericUpDown.Value;
            bool hasVeggies = burgerVeggies.Checked;
            Burger burger = new Burger();
            burger.addPatty(extraPatties);
            burger.addCheese(extraCheese);
            if (hasVeggies) burger.addVeggies();

            initPrice.Text = burger.Cost + " PHP";
        }

        private void createDummySide()
        {
            var typeRadio = sideTypes.Controls.OfType<RadioButton>()
                                            .FirstOrDefault(r => r.Checked);
            var sizeRadio = sideSize.Controls.OfType<RadioButton>()
                                           .FirstOrDefault(r => r.Checked);

            string type = typeRadio is not null ? typeRadio.Text : "None";
            string size = sizeRadio is not null ? sizeRadio.Text : "None";

            if (type == "None" || size == "None")
                return;
            var dummySide = new Side();
            dummySide.Type = type;
            dummySide.Size = size;
            initPrice.Text = dummySide.Cost + " PHP";
        }
    }
}
