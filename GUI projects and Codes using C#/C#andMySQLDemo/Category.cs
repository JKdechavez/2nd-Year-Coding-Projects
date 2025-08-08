using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_andMySQLDemo
{
    internal class Category
    {
        private int categoryID;
        private string categoryName;
        private string description;


        public Category(int categoryID, string categoryName, string Description) {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.description = Description; 
        }

        public int CategoryID { 
            get { return categoryID;} 
            set { categoryID = value; }
        }

        public string CategoryName { 
            get {  return categoryName;} 
            set {  categoryName = value; } 
        }  

        public string Description { 
            get { return description;} 
            set { description = value; }
        }


    }



}
