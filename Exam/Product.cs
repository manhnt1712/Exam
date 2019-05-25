using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public abstract class Product
    {
        public int productId;
        public string name;
        public string producer;
        public double price;
        public Product(int productId,string name,string producer,double price )
        {
            this.producer = producer;
            this.productId = productId;
            this.name = name;
            this.price = price;
        }
        public abstract double computeTax();

    }
}
