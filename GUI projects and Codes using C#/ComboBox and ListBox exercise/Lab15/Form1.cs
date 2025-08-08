using System.Linq.Expressions;

namespace Lab15
{
    public partial class Form1 : Form
    {
        double orderTotal = 0;
        string[] selectedAutoParts = new string[0];
        public Form1()
        {
            InitializeComponent();
            DescriptionComboBox.Focus();

        }

        private void dsdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPartToListBOxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                this.Close();

        }

        private void addPartToComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newItem = DescriptionComboBox.Text.ToString();
            if (newItem == null || newItem == "")
                MessageBox.Show("Cannot add blank to the options!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                bool decision = false;
                for (int i = 0; i < DescriptionComboBox.Items.Count; i++)
                {
                    if (DescriptionComboBox.Items[i].ToString().ToLower() == newItem.ToLower())
                    {
                        decision = true;
                    }
                }
                if (decision == false)
                    DescriptionComboBox.Items.Add(newItem);
                else
                    MessageBox.Show("Option already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DescriptionComboBox.SelectedValue = null;
            DescriptionComboBox.ResetText();
        }

        private void maintainPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ValidData(string autoPart, int autoPartIndex, double price, int quantity)
        {
            if (price <= 0)
            {
                MessageBox.Show("Invalid Price!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescriptionComboBox.SelectedItem = null;
                DescriptionComboBox.ResetText();
                SalesPriceTextBox.Clear();
                QuantityTextBox.Clear();
                DescriptionComboBox.Focus();
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Invalid Quantity!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescriptionComboBox.SelectedItem = null;
                DescriptionComboBox.ResetText();
                SalesPriceTextBox.Clear();
                QuantityTextBox.Clear();
                DescriptionComboBox.Focus();
            }
            else
            {
                listBox1.Items.Add($"{autoPart} - Price: ${price} - Qty: {quantity} - Line Total: ${price * quantity}");
                if (!selectedAutoParts.Contains(autoPart))
                {
                    Array.Resize(ref selectedAutoParts, selectedAutoParts.Length + 1);
                    selectedAutoParts[selectedAutoParts.Length - 1] = autoPart;
                }
                DescriptionComboBox.SelectedItem = null;
                DescriptionComboBox.ResetText();
                SalesPriceTextBox.Clear();
                QuantityTextBox.Clear();
                DescriptionComboBox.Focus();
            }
        }

        private void clearPartListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string autoPart;
            int autoPartIndex, quantity;
            double price;
            try
            {
                if (DescriptionComboBox.SelectedItem == null || DescriptionComboBox.SelectedItem.Equals(DescriptionComboBox.Items))
                {
                    MessageBox.Show("Selected Auto Part is not in options!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DescriptionComboBox.SelectedValue = null;
                    DescriptionComboBox.ResetText();
                    SalesPriceTextBox.Clear();
                    QuantityTextBox.Clear();
                    DescriptionComboBox.Focus();
                }

                else
                {
                    autoPart = DescriptionComboBox.SelectedItem.ToString();
                    autoPartIndex = DescriptionComboBox.SelectedIndex;
                    price = Convert.ToDouble(SalesPriceTextBox.Text);
                    quantity = Convert.ToInt32(QuantityTextBox.Text);
                    ValidData(autoPart, autoPartIndex, price, quantity);
                    orderTotal += price * quantity;
                    OrderTotalTextBox.Text = $"${orderTotal.ToString()}";
                }
            }
            catch
            {
                MessageBox.Show("Enter Sales Price or Quantity!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DescriptionComboBox.SelectedValue = null;
                DescriptionComboBox.ResetText();
                SalesPriceTextBox.Clear();
                QuantityTextBox.Clear();
                DescriptionComboBox.Focus();
            }

        }

        private void countPartsInListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to clear list?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                DescriptionComboBox.ResetText();
                SalesPriceTextBox.Clear();
                QuantityTextBox.Clear();
                listBox1.Items.Clear();
                OrderTotalTextBox.Clear();
                DescriptionComboBox.Focus();
                selectedAutoParts = new string[0];
            }
        }

        private void countPartsInListBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string selectedAutoPartsItems = string.Join(", ", selectedAutoParts);
            MessageBox.Show(@$"The total number of unique auto parts selected is {selectedAutoParts.Length.ToString()}.
These are: {selectedAutoPartsItems}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deletePartFromComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DescriptionComboBox.Text == "")
                MessageBox.Show("Cannot delete! Selected option is blank!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!DescriptionComboBox.Items.Contains(DescriptionComboBox.Text))
                MessageBox.Show("Cannot delete! Selected option does not exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                DescriptionComboBox.Items.Remove(DescriptionComboBox.Text);
            }
            DescriptionComboBox.SelectedValue = null;
            DescriptionComboBox.ResetText();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(@$"Name: John Kevin R. De Chavez
Date: {dateTime.ToString("MMMM dd, yyyy")}
Time: {dateTime.ToString("hh:mm:ss tt")}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}