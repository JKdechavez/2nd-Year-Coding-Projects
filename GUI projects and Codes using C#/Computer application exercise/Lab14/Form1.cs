namespace Lab14
{
    public partial class Form1 : Form
    {
        int visibleImage = 1;
        public Form1()
        {
            InitializeComponent();
            NewJaguarPicBox.BringToFront();
            visibleImage = 1;
            SelectedAutoTextBox.Text = "New Jaguar XJR 4-door Sedan";
            PriceTextBox.Text = "$84,700";
            this.BackColor = Color.Gray;
            CustomerNameTextBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (visibleImage != 1)
            {
                NewJaguarPicBox.BringToFront();
                visibleImage = 1;
                SelectedAutoTextBox.Text = "New Jaguar XJR 4-door Sedan";
                PriceTextBox.Text = "$84,700";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (visibleImage != 2)
            {
                UsedJaguarPicBox.BringToFront();
                visibleImage = 2;
                SelectedAutoTextBox.Text = "2006 Jaguar XK8 2-door Convertible";
                PriceTextBox.Text = "$40,989";
            }
        }

        private void UsedJaguarPicBox_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (visibleImage != 3)
            {
                ClassicJaguarPicBox.BringToFront();
                visibleImage = 3;
                SelectedAutoTextBox.Text = "1954 Jaguar D 2-door Convertible Classic";
                PriceTextBox.Text = "$189,950";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (visibilityCheckBox.Checked == false)
                MultilineTextBox.Visible = false;
            else
                MultilineTextBox.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || TelephoneTextBox.Text == "(   )    -")
            {
                MessageBox.Show("Name or Telephone number is missing!");
                CustomerNameTextBox.Focus();
            }
            else
            {
                MessageBox.Show(@$"Congratulations {CustomerNameTextBox.Text}!
We will telephone you at {TelephoneTextBox.Text}
when your {SelectedAutoTextBox.Text} priced at {PriceTextBox.Text}
is ready for delivery.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || TelephoneTextBox.Text == "(   )    -")
            {
                MessageBox.Show("Name or Telephone number is missing!");
                CustomerNameTextBox.Focus();
            }
            else
            {
                MultilineTextBox.Text = @$"Congratulations {CustomerNameTextBox.Text}!

We will telephone you at {TelephoneTextBox.Text}
when your {SelectedAutoTextBox.Text} priced at {PriceTextBox.Text}
is ready for delivery.";
                TelephoneTextBox.Focus();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CustomerNameTextBox.Clear();
            TelephoneTextBox.Clear();
            SelectedAutoTextBox.Text = "New Jaguar XJR 4-door Sedan";
            PriceTextBox.Text = "$84,700";
            Gray.Checked = true;
            this.BackColor = Color.Gray;
            NewJaguarRadButton.Checked = true;
            NewJaguarPicBox.BringToFront();
            visibleImage = 1;
            MultilineTextBox.Clear();
            CustomerNameTextBox.Focus();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CustomerNameTextBox.Text == "" || TelephoneTextBox.Text == "(   )    -")
                {
                    MessageBox.Show("Name or Telephone number is missing!");
                    CustomerNameTextBox.Focus();
                }
                else
                {
                    MultilineTextBox.Text = @$"Congratulations {CustomerNameTextBox.Text}!

We will telephone you at {TelephoneTextBox.Text}
when your {SelectedAutoTextBox.Text} priced at {PriceTextBox.Text}
is ready for delivery.";
                }
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CustomerNameTextBox.Clear();
                TelephoneTextBox.Clear();
                SelectedAutoTextBox.Text = "New Jaguar XJR 4-door Sedan";
                PriceTextBox.Text = "$84,700";
                Gray.Checked = true;
                this.BackColor = Color.Gray;
                NewJaguarRadButton.Checked = true;
                NewJaguarPicBox.BringToFront();
                visibleImage = 1;
                MultilineTextBox.Clear();
                CustomerNameTextBox.Focus();
            }
        }
    }
}
