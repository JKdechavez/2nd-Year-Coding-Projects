using System.Data;

namespace Lab22
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IDTextBox.Text, out int id) &&
                !string.IsNullOrEmpty(FirstNameTextBox.Text) &&
                !string.IsNullOrEmpty(LastNameTextBox.Text) &&
                !string.IsNullOrEmpty(EmailTextBox.Text) &&
                !string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                dataTable.Rows.Add(id, FirstNameTextBox.Text, LastNameTextBox.Text, PhoneTextBox.Text, EmailTextBox.Text);
                ClearTextBoxes();
            }
            else
                MessageBox.Show("Please enter a valid data.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataTable;
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("First Name", typeof(string));
            dataTable.Columns.Add("Last Name", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));

            dataTable.Rows.Add(4413, "John Kevin", "De Chavez", "09309445804", "jkdechavez31@gmail.com");
            dataTable.Rows.Add(4414, "Gwen Ashley", "Coniza", "09342234253", "gwencon16@gmail.com");
            dataTable.Rows.Add(4415, "Naomi Kristin", "Odejar", "09367545454", "naomiodejar10@gmail.com");
            dataTable.Rows.Add(4416, "Karl Ivan", "Mariscotes", "09839465783", "karlivanpogi123@gmail.com");
            dataTable.Rows.Add(4417, "Rainier Mae", "Bontigao", "09290677584", "rainybontigauk6911@gmail.com");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                IDTextBox.Text = selectedRow.Cells["ID"].Value.ToString();
                FirstNameTextBox.Text = selectedRow.Cells["First Name"].Value.ToString();
                LastNameTextBox.Text = selectedRow.Cells["Last Name"].Value.ToString();
                PhoneTextBox.Text = selectedRow.Cells["Phone"].Value.ToString();
                EmailTextBox.Text = selectedRow.Cells["email"].Value.ToString();

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(selectedIndex);
                ClearTextBoxes();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["ID"].Value = IDTextBox.Text;
                selectedRow.Cells["First Name"].Value = FirstNameTextBox.Text;
                selectedRow.Cells["Last Name"].Value = LastNameTextBox.Text;
                selectedRow.Cells["Phone"].Value = PhoneTextBox.Text;
                selectedRow.Cells["Email"].Value = EmailTextBox.Text;
                ClearTextBoxes();
                dataGridView1.Refresh();
            }
        }
        private void ClearTextBoxes()
        {
            IDTextBox.Clear();
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            PhoneTextBox.Clear();
            EmailTextBox.Clear();
        }
    }
}