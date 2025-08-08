namespace C_andMySQLDemo
{
    public partial class Form1 : Form
    {
        CategoryList categoryList;
        public Form1()
        {
            InitializeComponent();
            categoryList = new CategoryList();
            foreach (Category category in categoryList.findCategories())
            {
                listBox1.Items.Add(category.CategoryName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Update

            Category category = (Category) categoryList.Categories[2];
            category.CategoryName = "zzz";
            category.Description = "ccc";
            listBox1.Items[2] = category.CategoryName;
            categoryList.updateCategory(category);

            //Delete
            /*
            Category category = (Category)categoryList.Categories[7];
            listBox1.Items.RemoveAt(7);
            categoryList.deleteCategory(category);*/

            //Create
            /*
            Category category = new Category(0, "Sea Food", "sdfsdfsdfsd");
            categoryList.createCategory(category);
            listBox1.Items.Add((string)category.CategoryName);*/

        }
    }
}