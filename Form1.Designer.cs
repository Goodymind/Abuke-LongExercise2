namespace Abuke_LongExercise2
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrderOptions = new FlowLayoutPanel();
            label1 = new Label();
            addBurger = new Button();
            addSide = new Button();
            addWrap = new Button();
            label2 = new Label();
            ItemOptions = new FlowLayoutPanel();
            burgerPanel = new FlowLayoutPanel();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            extraPattiesNumericUpDown = new NumericUpDown();
            splitContainer2 = new SplitContainer();
            label5 = new Label();
            extraCheeseNumericUpDown = new NumericUpDown();
            burgerVeggies = new CheckBox();
            sidePanel = new FlowLayoutPanel();
            label6 = new Label();
            sideTypes = new FlowLayoutPanel();
            label8 = new Label();
            fries = new RadioButton();
            onionRings = new RadioButton();
            baconChips = new RadioButton();
            sideSize = new FlowLayoutPanel();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            wrapPanel = new FlowLayoutPanel();
            label9 = new Label();
            removeVeggies = new CheckBox();
            splitContainer3 = new SplitContainer();
            label10 = new Label();
            wrapExtraCheeseNumericUpDown = new NumericUpDown();
            label12 = new Label();
            spicePanel = new FlowLayoutPanel();
            mildRadio = new RadioButton();
            spicyRadio = new RadioButton();
            verySpicyRadio = new RadioButton();
            itemControlPanel = new FlowLayoutPanel();
            initPrice = new Label();
            button1 = new Button();
            OrderListPanel = new FlowLayoutPanel();
            label11 = new Label();
            orderList = new FlowLayoutPanel();
            totalPriceLabel = new Label();
            Save = new Button();
            load = new Button();
            OrderOptions.SuspendLayout();
            ItemOptions.SuspendLayout();
            burgerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)extraPattiesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)extraCheeseNumericUpDown).BeginInit();
            sidePanel.SuspendLayout();
            sideTypes.SuspendLayout();
            sideSize.SuspendLayout();
            wrapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wrapExtraCheeseNumericUpDown).BeginInit();
            spicePanel.SuspendLayout();
            itemControlPanel.SuspendLayout();
            OrderListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrderOptions
            // 
            OrderOptions.AutoSize = true;
            OrderOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OrderOptions.Controls.Add(label1);
            OrderOptions.Controls.Add(addBurger);
            OrderOptions.Controls.Add(addSide);
            OrderOptions.Controls.Add(addWrap);
            OrderOptions.Dock = DockStyle.Left;
            OrderOptions.Location = new Point(0, 25);
            OrderOptions.Name = "OrderOptions";
            OrderOptions.Size = new Size(118, 519);
            OrderOptions.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 3;
            label1.Text = "Add Item";
            // 
            // addBurger
            // 
            addBurger.Location = new Point(3, 28);
            addBurger.Name = "addBurger";
            addBurger.Size = new Size(112, 34);
            addBurger.TabIndex = 0;
            addBurger.Text = "Burger";
            addBurger.UseVisualStyleBackColor = true;
            addBurger.Click += addBurger_Click;
            // 
            // addSide
            // 
            addSide.Location = new Point(3, 68);
            addSide.Name = "addSide";
            addSide.Size = new Size(112, 34);
            addSide.TabIndex = 1;
            addSide.Text = "Side";
            addSide.UseVisualStyleBackColor = true;
            addSide.Click += addSide_Click;
            // 
            // addWrap
            // 
            addWrap.Location = new Point(3, 108);
            addWrap.Name = "addWrap";
            addWrap.Size = new Size(112, 34);
            addWrap.TabIndex = 2;
            addWrap.Text = "Wrap";
            addWrap.UseVisualStyleBackColor = true;
            addWrap.Click += addWrap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 1;
            label2.Text = "Long Exercise 2";
            // 
            // ItemOptions
            // 
            ItemOptions.AutoSize = true;
            ItemOptions.Controls.Add(burgerPanel);
            ItemOptions.Controls.Add(sidePanel);
            ItemOptions.Controls.Add(wrapPanel);
            ItemOptions.Controls.Add(itemControlPanel);
            ItemOptions.Dock = DockStyle.Left;
            ItemOptions.FlowDirection = FlowDirection.TopDown;
            ItemOptions.Location = new Point(118, 25);
            ItemOptions.MaximumSize = new Size(365, 475);
            ItemOptions.MinimumSize = new Size(365, 475);
            ItemOptions.Name = "ItemOptions";
            ItemOptions.Size = new Size(365, 475);
            ItemOptions.TabIndex = 2;
            ItemOptions.WrapContents = false;
            // 
            // burgerPanel
            // 
            burgerPanel.Anchor = AnchorStyles.Top;
            burgerPanel.AutoSize = true;
            burgerPanel.Controls.Add(label3);
            burgerPanel.Controls.Add(splitContainer1);
            burgerPanel.Controls.Add(splitContainer2);
            burgerPanel.Controls.Add(burgerVeggies);
            burgerPanel.FlowDirection = FlowDirection.TopDown;
            burgerPanel.Location = new Point(70, 3);
            burgerPanel.Name = "burgerPanel";
            burgerPanel.Size = new Size(231, 134);
            burgerPanel.TabIndex = 0;
            burgerPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 1;
            label3.Text = "Burger";
            // 
            // splitContainer1
            // 
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1MinSize = 45;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(extraPattiesNumericUpDown);
            splitContainer1.Panel2MinSize = 45;
            splitContainer1.Size = new Size(225, 31);
            splitContainer1.SplitterDistance = 120;
            splitContainer1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 3;
            label4.Text = "Extra Patties";
            // 
            // extraPattiesNumericUpDown
            // 
            extraPattiesNumericUpDown.Dock = DockStyle.Fill;
            extraPattiesNumericUpDown.Location = new Point(0, 0);
            extraPattiesNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            extraPattiesNumericUpDown.Name = "extraPattiesNumericUpDown";
            extraPattiesNumericUpDown.Size = new Size(101, 31);
            extraPattiesNumericUpDown.TabIndex = 0;
            extraPattiesNumericUpDown.ValueChanged += burgerSelected;
            // 
            // splitContainer2
            // 
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(3, 65);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1MinSize = 45;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(extraCheeseNumericUpDown);
            splitContainer2.Panel2MinSize = 45;
            splitContainer2.Size = new Size(225, 31);
            splitContainer2.SplitterDistance = 120;
            splitContainer2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 3;
            label5.Text = "Extra Cheese";
            // 
            // extraCheeseNumericUpDown
            // 
            extraCheeseNumericUpDown.Dock = DockStyle.Fill;
            extraCheeseNumericUpDown.Location = new Point(0, 0);
            extraCheeseNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            extraCheeseNumericUpDown.Name = "extraCheeseNumericUpDown";
            extraCheeseNumericUpDown.Size = new Size(101, 31);
            extraCheeseNumericUpDown.TabIndex = 0;
            extraCheeseNumericUpDown.ValueChanged += burgerSelected;
            // 
            // burgerVeggies
            // 
            burgerVeggies.AutoSize = true;
            burgerVeggies.Location = new Point(3, 102);
            burgerVeggies.Name = "burgerVeggies";
            burgerVeggies.Size = new Size(100, 29);
            burgerVeggies.TabIndex = 0;
            burgerVeggies.Text = "Veggies";
            burgerVeggies.UseVisualStyleBackColor = true;
            burgerVeggies.CheckedChanged += burgerSelected;
            // 
            // sidePanel
            // 
            sidePanel.Anchor = AnchorStyles.Top;
            sidePanel.AutoSize = true;
            sidePanel.Controls.Add(label6);
            sidePanel.Controls.Add(sideTypes);
            sidePanel.Controls.Add(sideSize);
            sidePanel.Location = new Point(28, 143);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(314, 136);
            sidePanel.TabIndex = 1;
            sidePanel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 1;
            label6.Text = "Side";
            // 
            // sideTypes
            // 
            sideTypes.AutoSize = true;
            sideTypes.Controls.Add(label8);
            sideTypes.Controls.Add(fries);
            sideTypes.Controls.Add(onionRings);
            sideTypes.Controls.Add(baconChips);
            sideTypes.Dock = DockStyle.Left;
            sideTypes.FlowDirection = FlowDirection.TopDown;
            sideTypes.Location = new Point(55, 3);
            sideTypes.Name = "sideTypes";
            sideTypes.Size = new Size(141, 130);
            sideTypes.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 6;
            label8.Text = "Type";
            // 
            // fries
            // 
            fries.AutoSize = true;
            fries.Checked = true;
            fries.Location = new Point(3, 28);
            fries.Name = "fries";
            fries.Size = new Size(73, 29);
            fries.TabIndex = 4;
            fries.TabStop = true;
            fries.Text = "Fries";
            fries.UseVisualStyleBackColor = true;
            fries.CheckedChanged += sideSizeTypeSelected;
            // 
            // onionRings
            // 
            onionRings.AutoSize = true;
            onionRings.Location = new Point(3, 63);
            onionRings.Name = "onionRings";
            onionRings.Size = new Size(135, 29);
            onionRings.TabIndex = 5;
            onionRings.Text = "Onion Rings";
            onionRings.UseVisualStyleBackColor = true;
            onionRings.CheckedChanged += sideSizeTypeSelected;
            // 
            // baconChips
            // 
            baconChips.AutoSize = true;
            baconChips.Location = new Point(3, 98);
            baconChips.Name = "baconChips";
            baconChips.Size = new Size(134, 29);
            baconChips.TabIndex = 3;
            baconChips.Text = "Bacon Chips";
            baconChips.UseVisualStyleBackColor = true;
            baconChips.CheckedChanged += sideSizeTypeSelected;
            // 
            // sideSize
            // 
            sideSize.AutoSize = true;
            sideSize.Controls.Add(label7);
            sideSize.Controls.Add(radioButton1);
            sideSize.Controls.Add(radioButton2);
            sideSize.Dock = DockStyle.Left;
            sideSize.FlowDirection = FlowDirection.TopDown;
            sideSize.Location = new Point(202, 3);
            sideSize.Name = "sideSize";
            sideSize.Size = new Size(109, 130);
            sideSize.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 25);
            label7.TabIndex = 6;
            label7.Text = "Size";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 29);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Medium";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += sideSizeTypeSelected;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 29);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Large";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += sideSizeTypeSelected;
            // 
            // wrapPanel
            // 
            wrapPanel.Anchor = AnchorStyles.Top;
            wrapPanel.AutoSize = true;
            wrapPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            wrapPanel.Controls.Add(label9);
            wrapPanel.Controls.Add(removeVeggies);
            wrapPanel.Controls.Add(splitContainer3);
            wrapPanel.Controls.Add(label12);
            wrapPanel.Controls.Add(spicePanel);
            wrapPanel.FlowDirection = FlowDirection.TopDown;
            wrapPanel.Location = new Point(3, 285);
            wrapPanel.Name = "wrapPanel";
            wrapPanel.Size = new Size(365, 166);
            wrapPanel.TabIndex = 2;
            wrapPanel.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 25);
            label9.TabIndex = 0;
            label9.Text = "Wrap";
            // 
            // removeVeggies
            // 
            removeVeggies.AutoSize = true;
            removeVeggies.Location = new Point(3, 28);
            removeVeggies.Name = "removeVeggies";
            removeVeggies.Size = new Size(169, 29);
            removeVeggies.TabIndex = 1;
            removeVeggies.Text = "Remove Veggies";
            removeVeggies.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Anchor = AnchorStyles.Top;
            splitContainer3.FixedPanel = FixedPanel.Panel1;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(3, 63);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(label10);
            splitContainer3.Panel1MinSize = 50;
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(wrapExtraCheeseNumericUpDown);
            splitContainer3.Panel2MinSize = 50;
            splitContainer3.Size = new Size(359, 34);
            splitContainer3.SplitterDistance = 200;
            splitContainer3.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(111, 25);
            label10.TabIndex = 3;
            label10.Text = "Extra Cheese";
            // 
            // wrapExtraCheeseNumericUpDown
            // 
            wrapExtraCheeseNumericUpDown.Dock = DockStyle.Fill;
            wrapExtraCheeseNumericUpDown.Location = new Point(0, 0);
            wrapExtraCheeseNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            wrapExtraCheeseNumericUpDown.Name = "wrapExtraCheeseNumericUpDown";
            wrapExtraCheeseNumericUpDown.Size = new Size(155, 31);
            wrapExtraCheeseNumericUpDown.TabIndex = 0;
            wrapExtraCheeseNumericUpDown.ValueChanged += wrapSelected;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Location = new Point(3, 100);
            label12.Name = "label12";
            label12.Size = new Size(359, 25);
            label12.TabIndex = 0;
            label12.Text = "Spice Level";
            // 
            // spicePanel
            // 
            spicePanel.AutoSize = true;
            spicePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            spicePanel.Controls.Add(mildRadio);
            spicePanel.Controls.Add(spicyRadio);
            spicePanel.Controls.Add(verySpicyRadio);
            spicePanel.Dock = DockStyle.Fill;
            spicePanel.Location = new Point(3, 128);
            spicePanel.Name = "spicePanel";
            spicePanel.Size = new Size(359, 35);
            spicePanel.TabIndex = 5;
            // 
            // mildRadio
            // 
            mildRadio.AutoSize = true;
            mildRadio.Checked = true;
            mildRadio.Dock = DockStyle.Left;
            mildRadio.Location = new Point(3, 3);
            mildRadio.Name = "mildRadio";
            mildRadio.Size = new Size(72, 29);
            mildRadio.TabIndex = 1;
            mildRadio.TabStop = true;
            mildRadio.Text = "Mild";
            mildRadio.UseVisualStyleBackColor = true;
            // 
            // spicyRadio
            // 
            spicyRadio.AutoSize = true;
            spicyRadio.Dock = DockStyle.Left;
            spicyRadio.Location = new Point(81, 3);
            spicyRadio.Name = "spicyRadio";
            spicyRadio.Size = new Size(79, 29);
            spicyRadio.TabIndex = 2;
            spicyRadio.Text = "Spicy";
            spicyRadio.UseVisualStyleBackColor = true;
            // 
            // verySpicyRadio
            // 
            verySpicyRadio.AutoSize = true;
            verySpicyRadio.Dock = DockStyle.Left;
            verySpicyRadio.Location = new Point(166, 3);
            verySpicyRadio.Name = "verySpicyRadio";
            verySpicyRadio.Size = new Size(118, 29);
            verySpicyRadio.TabIndex = 3;
            verySpicyRadio.Text = "Very Spicy";
            verySpicyRadio.UseVisualStyleBackColor = true;
            // 
            // itemControlPanel
            // 
            itemControlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            itemControlPanel.AutoSize = true;
            itemControlPanel.Controls.Add(initPrice);
            itemControlPanel.Controls.Add(button1);
            itemControlPanel.FlowDirection = FlowDirection.TopDown;
            itemControlPanel.Location = new Point(209, 457);
            itemControlPanel.Name = "itemControlPanel";
            itemControlPanel.Size = new Size(159, 66);
            itemControlPanel.TabIndex = 3;
            // 
            // initPrice
            // 
            initPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            initPrice.AutoSize = true;
            initPrice.Location = new Point(134, 0);
            initPrice.Name = "initPrice";
            initPrice.Size = new Size(22, 25);
            initPrice.TabIndex = 1;
            initPrice.Text = "0";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(3, 28);
            button1.Name = "button1";
            button1.Size = new Size(153, 35);
            button1.TabIndex = 2;
            button1.Text = "Add to order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OrderListPanel
            // 
            OrderListPanel.AutoScroll = true;
            OrderListPanel.AutoSize = true;
            OrderListPanel.Controls.Add(label11);
            OrderListPanel.Controls.Add(orderList);
            OrderListPanel.Controls.Add(totalPriceLabel);
            OrderListPanel.Controls.Add(Save);
            OrderListPanel.Controls.Add(load);
            OrderListPanel.Dock = DockStyle.Left;
            OrderListPanel.FlowDirection = FlowDirection.TopDown;
            OrderListPanel.Location = new Point(483, 25);
            OrderListPanel.MinimumSize = new Size(0, 519);
            OrderListPanel.Name = "OrderListPanel";
            OrderListPanel.Size = new Size(118, 519);
            OrderListPanel.TabIndex = 0;
            OrderListPanel.WrapContents = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(89, 25);
            label11.TabIndex = 0;
            label11.Text = "Order List";
            // 
            // orderList
            // 
            orderList.AutoSize = true;
            orderList.Dock = DockStyle.Fill;
            orderList.FlowDirection = FlowDirection.TopDown;
            orderList.Location = new Point(3, 28);
            orderList.Name = "orderList";
            orderList.Padding = new Padding(40, 20, 40, 20);
            orderList.Size = new Size(112, 40);
            orderList.TabIndex = 4;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(3, 71);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(110, 25);
            totalPriceLabel.TabIndex = 5;
            totalPriceLabel.Text = "Total Price: 0";
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Save.Location = new Point(3, 99);
            Save.Name = "Save";
            Save.Size = new Size(112, 34);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            load.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            load.Location = new Point(3, 139);
            load.Name = "load";
            load.Size = new Size(112, 34);
            load.TabIndex = 3;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(828, 544);
            Controls.Add(OrderListPanel);
            Controls.Add(ItemOptions);
            Controls.Add(OrderOptions);
            Controls.Add(label2);
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "Form1";
            Text = "Form1";
            OrderOptions.ResumeLayout(false);
            OrderOptions.PerformLayout();
            ItemOptions.ResumeLayout(false);
            ItemOptions.PerformLayout();
            burgerPanel.ResumeLayout(false);
            burgerPanel.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)extraPattiesNumericUpDown).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)extraCheeseNumericUpDown).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            sideTypes.ResumeLayout(false);
            sideTypes.PerformLayout();
            sideSize.ResumeLayout(false);
            sideSize.PerformLayout();
            wrapPanel.ResumeLayout(false);
            wrapPanel.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wrapExtraCheeseNumericUpDown).EndInit();
            spicePanel.ResumeLayout(false);
            spicePanel.PerformLayout();
            itemControlPanel.ResumeLayout(false);
            itemControlPanel.PerformLayout();
            OrderListPanel.ResumeLayout(false);
            OrderListPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel OrderOptions;
        private Label label1;
        private Button addBurger;
        private Button addSide;
        private Button addWrap;
        private Label label2;
        private FlowLayoutPanel ItemOptions;
        private FlowLayoutPanel OrderListPanel;
        private FlowLayoutPanel burgerPanel;
        private CheckBox burgerVeggies;
        private Label label3;
        private SplitContainer splitContainer1;
        private Label label4;
        private SplitContainer splitContainer2;
        private Label label5;
        private FlowLayoutPanel sidePanel;
        private Label label6;
        private FlowLayoutPanel sideTypes;
        private RadioButton fries;
        private RadioButton onionRings;
        private RadioButton baconChips;
        private Label label8;
        private FlowLayoutPanel sideSize;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private FlowLayoutPanel wrapPanel;
        private Label label9;
        private CheckBox removeVeggies;
        private SplitContainer splitContainer3;
        private Label label10;
        private Label label11;
        private FlowLayoutPanel itemControlPanel;
        private Label initPrice;
        private Button button1;
        private Button Save;
        private Button load;
        private NumericUpDown extraPattiesNumericUpDown;
        private NumericUpDown extraCheeseNumericUpDown;
        private FlowLayoutPanel orderList;
        private OrderItem orderItem1;
        private OrderItem orderItem2;
        private Label totalPriceLabel;
        private NumericUpDown wrapExtraCheeseNumericUpDown;
        private FlowLayoutPanel spicePanel;
        private Label label12;
        private RadioButton mildRadio;
        private RadioButton spicyRadio;
        private RadioButton verySpicyRadio;
    }
}
