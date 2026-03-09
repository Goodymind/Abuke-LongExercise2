namespace Abuke_LongExercise2
{
    partial class OrderItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            itemLabel = new Label();
            price = new Label();
            remove = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(itemLabel);
            flowLayoutPanel1.Controls.Add(price);
            flowLayoutPanel1.Controls.Add(remove);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(118, 90);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(3, 0);
            itemLabel.MaximumSize = new Size(200, 0);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(0, 25);
            itemLabel.TabIndex = 0;
            // 
            // price
            // 
            price.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            price.AutoSize = true;
            price.Location = new Point(56, 25);
            price.Name = "price";
            price.Size = new Size(59, 25);
            price.TabIndex = 1;
            price.Text = "label2";
            // 
            // remove
            // 
            remove.Dock = DockStyle.Right;
            remove.Location = new Point(3, 53);
            remove.Name = "remove";
            remove.Size = new Size(112, 34);
            remove.TabIndex = 2;
            remove.Text = "remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // OrderItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(flowLayoutPanel1);
            Name = "OrderItem";
            Size = new Size(118, 90);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label itemLabel;
        private Label price;
        private Button remove;
    }
}
