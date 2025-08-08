namespace Lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            informationLabel.Text = "Family Wagon, immaculate condition $12,995";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hoursLabel.Visible = checkBox1.Checked;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            informationLabel.Text = "Complete detail $79.95 for most cars.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            informationLabel.Text = "Lube, oil, filter $25.99";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            informationLabel.Text = "Sales position contact Mr. Mann 551-2134 x475";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            informationLabel.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            informationLabel.ForeColor = Color.Crimson;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            informationLabel.ForeColor = Color.Aquamarine;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            informationLabel.ForeColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            informationLabel.ForeColor = Color.Crimson;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}