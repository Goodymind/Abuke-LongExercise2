using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Abuke_LongExercise2
{
    public partial class OrderDetail : Form
    {
        public OrderDetail(XmlNode order)
        {
            InitializeComponent();
            Text = "Order No: " + order["Id"].InnerText;

            var items = order["Items"].ChildNodes;
            int total_price = 0;
            orderLabel.Text = "";
            foreach (XmlNode item in items)
            {
                var desc = item["Description"].InnerText;
                var cost = item["Cost"].InnerText;
                total_price += int.Parse(cost);

                orderLabel.Text += desc + ": " + cost + "PHP\n";
            }

            orderLabel.Text += "Total Price: " + total_price + "PHP";
        
        }
    }
}
