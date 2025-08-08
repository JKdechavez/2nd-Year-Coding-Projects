namespace Lab15
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            dsdToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            maintainPartsToolStripMenuItem = new ToolStripMenuItem();
            addPartToComboBoxToolStripMenuItem = new ToolStripMenuItem();
            deletePartFromComboBoxToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            clearPartListBoxToolStripMenuItem = new ToolStripMenuItem();
            countPartsInListBoxToolStripMenuItem = new ToolStripMenuItem();
            countPartsInListBoxToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            DescriptionComboBox = new ComboBox();
            SalesPriceTextBox = new TextBox();
            label3 = new Label();
            QuantityTextBox = new TextBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            OrderTotalTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dsdToolStripMenuItem, maintainPartsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(567, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dsdToolStripMenuItem
            // 
            dsdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            dsdToolStripMenuItem.Name = "dsdToolStripMenuItem";
            dsdToolStripMenuItem.Size = new Size(37, 20);
            dsdToolStripMenuItem.Text = "File";
            dsdToolStripMenuItem.Click += dsdToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // maintainPartsToolStripMenuItem
            // 
            maintainPartsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPartToComboBoxToolStripMenuItem, deletePartFromComboBoxToolStripMenuItem, toolStripSeparator1, clearPartListBoxToolStripMenuItem, countPartsInListBoxToolStripMenuItem, countPartsInListBoxToolStripMenuItem1 });
            maintainPartsToolStripMenuItem.Name = "maintainPartsToolStripMenuItem";
            maintainPartsToolStripMenuItem.Size = new Size(95, 20);
            maintainPartsToolStripMenuItem.Text = "Maintain Parts";
            maintainPartsToolStripMenuItem.Click += maintainPartsToolStripMenuItem_Click;
            // 
            // addPartToComboBoxToolStripMenuItem
            // 
            addPartToComboBoxToolStripMenuItem.Name = "addPartToComboBoxToolStripMenuItem";
            addPartToComboBoxToolStripMenuItem.Size = new Size(223, 22);
            addPartToComboBoxToolStripMenuItem.Text = "Add Part to ComboBox";
            addPartToComboBoxToolStripMenuItem.Click += addPartToComboBoxToolStripMenuItem_Click;
            // 
            // deletePartFromComboBoxToolStripMenuItem
            // 
            deletePartFromComboBoxToolStripMenuItem.Name = "deletePartFromComboBoxToolStripMenuItem";
            deletePartFromComboBoxToolStripMenuItem.Size = new Size(223, 22);
            deletePartFromComboBoxToolStripMenuItem.Text = "Delete Part from ComboBox";
            deletePartFromComboBoxToolStripMenuItem.Click += deletePartFromComboBoxToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(220, 6);
            // 
            // clearPartListBoxToolStripMenuItem
            // 
            clearPartListBoxToolStripMenuItem.Name = "clearPartListBoxToolStripMenuItem";
            clearPartListBoxToolStripMenuItem.Size = new Size(223, 22);
            clearPartListBoxToolStripMenuItem.Text = "Add Part to ListBox";
            clearPartListBoxToolStripMenuItem.Click += clearPartListBoxToolStripMenuItem_Click;
            // 
            // countPartsInListBoxToolStripMenuItem
            // 
            countPartsInListBoxToolStripMenuItem.Name = "countPartsInListBoxToolStripMenuItem";
            countPartsInListBoxToolStripMenuItem.Size = new Size(223, 22);
            countPartsInListBoxToolStripMenuItem.Text = "Clear Part ListBox";
            countPartsInListBoxToolStripMenuItem.Click += countPartsInListBoxToolStripMenuItem_Click;
            // 
            // countPartsInListBoxToolStripMenuItem1
            // 
            countPartsInListBoxToolStripMenuItem1.Name = "countPartsInListBoxToolStripMenuItem1";
            countPartsInListBoxToolStripMenuItem1.Size = new Size(223, 22);
            countPartsInListBoxToolStripMenuItem1.Text = "Count Parts in ListBox";
            countPartsInListBoxToolStripMenuItem1.Click += countPartsInListBoxToolStripMenuItem1_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Description: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 57);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Sales Price: ";
            // 
            // DescriptionComboBox
            // 
            DescriptionComboBox.FormattingEnabled = true;
            DescriptionComboBox.Items.AddRange(new object[] { "Brake Pads", "Engine", "Injector", "Oil Filter", "Tire", "Transmission", "Wheel Rim" });
            DescriptionComboBox.Location = new Point(90, 25);
            DescriptionComboBox.Name = "DescriptionComboBox";
            DescriptionComboBox.Size = new Size(427, 23);
            DescriptionComboBox.TabIndex = 3;
            DescriptionComboBox.SelectedIndexChanged += DescriptionComboBox_SelectedIndexChanged;
            // 
            // SalesPriceTextBox
            // 
            SalesPriceTextBox.Location = new Point(90, 54);
            SalesPriceTextBox.Name = "SalesPriceTextBox";
            SalesPriceTextBox.Size = new Size(134, 23);
            SalesPriceTextBox.TabIndex = 4;
            SalesPriceTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 57);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity to be Shipped:";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(368, 54);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(149, 23);
            QuantityTextBox.TabIndex = 6;
            QuantityTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(11, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(506, 109);
            listBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(QuantityTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(SalesPriceTextBox);
            groupBox1.Controls.Add(DescriptionComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 208);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Part and Order Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 278);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 8;
            label4.Text = "Order Total:";
            // 
            // OrderTotalTextBox
            // 
            OrderTotalTextBox.Location = new Point(393, 275);
            OrderTotalTextBox.Name = "OrderTotalTextBox";
            OrderTotalTextBox.ReadOnly = true;
            OrderTotalTextBox.Size = new Size(139, 23);
            OrderTotalTextBox.TabIndex = 8;
            OrderTotalTextBox.TabStop = false;
            OrderTotalTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 312);
            Controls.Add(OrderTotalTextBox);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "The Edwardsville Auto Store";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dsdToolStripMenuItem;
        private ToolStripMenuItem maintainPartsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ComboBox DescriptionComboBox;
        private TextBox SalesPriceTextBox;
        private Label label3;
        private TextBox QuantityTextBox;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox OrderTotalTextBox;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addPartToComboBoxToolStripMenuItem;
        private ToolStripMenuItem deletePartFromComboBoxToolStripMenuItem;
        private ToolStripMenuItem clearPartListBoxToolStripMenuItem;
        private ToolStripMenuItem countPartsInListBoxToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem countPartsInListBoxToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
    }
}