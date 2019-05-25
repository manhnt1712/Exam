using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class Book :Product
    {
        public Book(int ProductId, string name, string producer, double price) : base(ProductId, name, producer, price) { }
        public override double computeTax() {
            return this.price*8/100;
        }
    }
}
