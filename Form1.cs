
using Abuke_LongExercise1;
using System.Xml;
namespace Abuke_LongExercise2
{
    public partial class Form1 : Form
    {
        private int totalPrice;
        private int TotalPrice
        {
            get { return totalPrice; }
            set
            {
                totalPrice = value;
                totalPriceLabel.Text = "Total Price " + totalPrice + " PHP";
            }
        }

        private OrderLoader orderLoader;

        public Form1()
        {
            InitializeComponent();
            orderLoader = new OrderLoader("orders.xml");
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
            createDummyWrap();
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

        private void addNewBurger()
        {
            int extraPatties = (int)extraPattiesNumericUpDown.Value;
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

        private void addNewSide()
        {
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

        private void addNewWrap()
        {
            int extraCheese = (int)wrapExtraCheeseNumericUpDown.Value;
            bool allmeat = removeVeggies.Checked;
            var spiceRadio = spicePanel.Controls.OfType<RadioButton>()
                                                .FirstOrDefault(r => r.Checked);
            string spiceLevel = spiceRadio is not null ? spiceRadio.Text : "None";

            if (spiceLevel == "None")
            {
                return;
            }

            var wrap = new Wrap();
            wrap.AddCheese(extraCheese);
            wrap.SetSpiceLevel(spiceLevel);
            if (allmeat) wrap.RemoveVeggies();

            var wrapItem = new OrderItem();
            wrapItem.Item = wrap;
            wrapItem.removeOrderItem += removeOrderItem;
            orderList.Controls.Add(wrapItem);
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

        private void wrapSelected(object? sender, EventArgs e)
        {
            createDummyWrap();
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

        private void createDummyWrap()
        {
            int extraCheese = (int)wrapExtraCheeseNumericUpDown.Value;
            bool allmeat = removeVeggies.Checked;
            var spiceRadio = spicePanel.Controls.OfType<RadioButton>()
                                                .FirstOrDefault(r => r.Checked);
            string spiceLevel = spiceRadio is not null ? spiceRadio.Text : "None";

            if (spiceLevel == "None")
            {
                return;
            }

            var wrap = new Wrap();
            wrap.AddCheese(extraCheese);
            wrap.SetSpiceLevel(spiceLevel);
            if (allmeat) wrap.RemoveVeggies();

            initPrice.Text = wrap.Cost + " PHP";
        }

        private void save_Click(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = orderList.Controls.OfType<OrderItem>().ToList();
            if (orderItems.Count == 0)
                return;

            var order = new Order(orderLoader.CurrentID);

            for (int i = 0; i < orderItems.Count; i++)
            {
                var oi = orderItems.ElementAt(i);
                order.Items.Add(oi.Item);
                orderList.Controls.Remove(oi);
                oi.Dispose();
            }

            TotalPrice = 0;

            orderLoader.addOrder(order);

            DialogResult result = MessageBox.Show(
                "Order has been saved.\nOrder No: " + (orderLoader.CurrentID - 1),
                "Confirmation",
                MessageBoxButtons.OK
                );

        }

        private void load_Click(object sender, EventArgs e)
        {
            int no = (int) orderNoNumUpDown.Value;
            var result = orderLoader.getOrder(no);

            if (result == null)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Order no. " + no.ToString() + " Does not exist",
                    "Error",
                    MessageBoxButtons.OK
                    );
                return;
            }
            var od = new OrderDetail(result);
            od.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int no = (int)orderNoNumUpDown.Value;

            if (no == 0)
            {
                int id = orderLoader.deleteFirst();
                if (id == -1)
                {
                    MessageBox.Show(
                        "There are no orders saved",
                        "Deleteion failed",
                        MessageBoxButtons.OK
                    );
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Order no. " + id.ToString() + " Deleted",
                        "Deleteion successful",
                        MessageBoxButtons.OK
                    );
                    return;
                }
            }

            var result = orderLoader.getOrder(no);

            if (result == null)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Order no. " + no.ToString() + " Does not exist",
                    "Error",
                    MessageBoxButtons.OK
                    );
                return;
            }
            MessageBox.Show(
                    "Order no. " + no.ToString() + " Deleted",
                    "Deleteion successful",
                    MessageBoxButtons.OK
                    );
            orderLoader.deleteOrder(result);
        }
    }
}
