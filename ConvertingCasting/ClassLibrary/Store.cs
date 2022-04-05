using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        public Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; }
        public void FindByNo(int no)
        {
            foreach (var item in Products)
            {
                if(item.No == no)
                    Console.WriteLine(item.Name);
            }
        }
       public double CalcNotebookAvg()
        {
            double count = 0;
            double sum = 0;
            foreach (var item in Products)
            {
                if (item is Notebook)
                {
                    count++;
                    sum += item.Price;
                }
            }
            return sum/count;
        }
       public double CalcPhoneAvg()
        {
            double count = 0;
            double sum = 0;
            foreach (var item in Products)
            {
                if (item is Phone)
                {
                    count++;
                    sum += item.Price;
                }
            }
            return sum / count;
        }
    }
}
