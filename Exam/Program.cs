using System;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            double totalTax = 0;
            List<Product> productList = new List<Product>();
            Product book1 = new Book(1,"hahahaha","nguyen van A",1000);
            productList.Add(book1);
            Product book2 = new Book(2, "dac nhan tam", "micheal", 2000);
            productList.Add(book2);
            Product book3 = new Book(3, "ca dao", "Tap Can Binh", 3000);
            productList.Add(book3);
            Product phone1 = new MobilePhone(4, "Iphone", "Apple", 6000);
            productList.Add(phone1);
            Product phone2 = new MobilePhone(5, "Note3", "SamSung", 9000);
            productList.Add(phone2);
            Product phone3 = new MobilePhone(6, "X5", "Sony", 10000);
            productList.Add(phone3);

            for(int i=0; i < productList.Count; i++)
            {
                if(productList[i] is Book) {
                    Console.WriteLine((i+1)+".Bookname: " + productList[i].name + "  Price: " + productList[i].price + "  Tax: " + productList[i].computeTax());
                }
                else {
                    Console.WriteLine((i+1)+".Phonename: " + productList[i].name + "  Price: " + productList[i].price + "  Tax: " + productList[i].computeTax());
                }
                totalTax += productList[i].computeTax();
       
            }
            Console.WriteLine("Total Tax: "+totalTax);
            
        }
    }
}
