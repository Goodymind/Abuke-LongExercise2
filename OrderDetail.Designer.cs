namespace Abuke_LongExercise2
{
    partial class OrderDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderLabel = new Label();
            SuspendLayout();
            // 
            // orderLabel
            // 
            orderLabel.Dock = DockStyle.Fill;
            orderLabel.Location = new Point(50, 50);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(724, 421);
            orderLabel.TabIndex = 0;
            orderLabel.Text = "label1";
            // 
            // OrderDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 521);
            Controls.Add(orderLabel);
            Name = "OrderDetail";
            Padding = new Padding(50);
            Text = "Order";
            ResumeLayout(false);
        }

        #endregion

        private Label orderLabel;
    }
}