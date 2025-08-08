using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    internal class Product
    {
        private int productID;
        private string productName;
        private string description;
        private double price;
        private int stocksNum;
        private string imageURL;


        public Product(int productID, string productName, string description, double price, int stocksNum, string imageURL)
        {
            this.productID = productID;
            this.productName = productName;
            this.description = description;
            this.price = price;
            this.stocksNum = stocksNum;
            this.imageURL = imageURL;
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int StocksNum
        {
            get { return stocksNum; }
            set { stocksNum = value; }
        }
        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }

        }



    }
}

