using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachPro3;

namespace Lab18
{
    internal class ProductList : Database
    {
        public ArrayList products;

        public ProductList()
        {
            products = new ArrayList();
        }

        public ArrayList Products
        {
            get { return products; }
        }


        public void createCategory(Product product)
        {
            OpenConnection();
            Command.CommandText = "INSERT INTO products(Product ID, Product Description) values ('";
            Command.CommandText += product.ProductID + "', '";
            Command.ExecuteNonQuery();
            CloseConnection();
            products.Add(product);
        }



        public ArrayList findProducts()
        {
            OpenConnection();
            Command.CommandText = "SELECT * FROM products";
            Reader = Command.ExecuteReader();
            if (Reader != null)
            {
                while (Reader.Read())
                {
                    products.Add(new Product(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetDouble(3), Reader.GetInt32(4), Reader.GetString(5)));
                }
            }

            CloseConnection();
            return products;

        }
    }
}
/*
        public void deleteCategory(Category category)
        {
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
                if (category.CategoryID == ((Category)categories[i]).CategoryID)
                {
                    ((Category)categories[i]).CategoryName = category.CategoryName;
                    ((Category)categories[i]).Description = category.Description;
                }
            }
        }
    }
}
*/
