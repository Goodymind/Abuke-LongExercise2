using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abuke_LongExercise1;

namespace Abuke_LongExercise2
{
    public partial class OrderItem : UserControl
    {

        private Item item;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Item Item
        {
            get { return item; } 
            set { 
                item = value; 
                itemLabel.Text = item.ToString();
                price.Text = item.Cost.ToString();
            }
        
        }

        public EventHandler removeOrderItem;

        public OrderItem()
        {
            InitializeComponent();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            removeOrderItem?.Invoke(this, EventArgs.Empty);
        }
    }
}
