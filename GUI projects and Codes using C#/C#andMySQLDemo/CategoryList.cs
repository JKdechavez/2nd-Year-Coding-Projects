using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_andMySQLDemo
{
    internal class CategoryList:Database
    {
        private ArrayList categories;

        public CategoryList() { 
            categories = new ArrayList();
        }

        public ArrayList Categories
        {
            get { return categories; }
        }
           
        
        public void createCategory(Category category)
        {
            OpenConnection();
            Command.CommandText = "INSERT INTO categories(CategoryName, Description) values ('";
            Command.CommandText += category.CategoryName + "', '";
            Command.CommandText += category.Description + "')";
            Command.ExecuteNonQuery();
            CloseConnection();
            categories.Add(category);
        }

        
        
        public ArrayList findCategories()
        {  
            OpenConnection();
            Command.CommandText = "SELECT * FROM categories";
            Reader = Command.ExecuteReader();
            if ( Reader != null )
            {
                while ( Reader.Read() )
                {
                    categories.Add(new Category(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2)));      
                }
            }

            CloseConnection();
            return categories;
            
        }

        public void deleteCategory(Category category) {
            OpenConnection();
            Command.CommandText = "DELETE FROM categories where CategoryID = " + category.CategoryID;
            Command.ExecuteNonQuery();
            CloseConnection();
            for (int i = 0; i < categories.Count; i++)
            {
                if (category.CategoryID == ((Category)categories[i]).CategoryID)
                {
                    categories.RemoveAt(i);
                    break;
                }
            }
        }

        public void updateCategory(Category category)
        {
            OpenConnection();
            Command.CommandText = "UPDATE categories set CategoryName = '";
            Command.CommandText += category.CategoryName + "', Description = '";
            Command.CommandText += category.Description + "' where CategoryID = ";
            Command.CommandText += category.CategoryID;

            Command.ExecuteNonQuery();
            CloseConnection();
            for (int i = 0; i < categories.Count; i++)
            {
                if (category.CategoryID == ((Category) categories[i]).CategoryID)
                {
                    ((Category)categories[i]).CategoryName = category.CategoryName;
                    ((Category)categories[i]).Description = category.Description;
                }
            }
        }
    }
}
