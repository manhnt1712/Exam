using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class MobilePhone : Product
    {
        public MobilePhone(int ProductId, string name, string producer, double price) : base(ProductId, name, producer, price) { }
        public override double computeTax()
        {
            return this.price * 1 / 10;
        }
    }
}
