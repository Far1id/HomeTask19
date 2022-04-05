using System;
using ClassLibrary;

namespace ConvertingCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Price = 200;
            product1.No = 123;
            product1.Name = "Product1";
            Notebook product2 = new Notebook();
            product2.Price = 2500;
            product2.No = 452;
            product2.Name = "Product2";
            Notebook product3 = new Notebook();
            product3.Price = 3500;
            product3.No = 564;
            product3.Name = "Product3";
            Phone product4 = new Phone();
            product4.Price = 750;
            product4.No = 589;
            product4.Name = "Product4";
            Phone product5 = new Phone();
            product5.Price = 1250;
            product5.No = 695;
            product5.Name = "Product5";

            Store HikmetinMarketi = new Store();
            HikmetinMarketi.AddProduct(product1);
            HikmetinMarketi.AddProduct(product2);
            HikmetinMarketi.AddProduct(product3);
            HikmetinMarketi.AddProduct(product4);
            HikmetinMarketi.AddProduct(product5);

            HikmetinMarketi.FindByNo(564);

            Console.WriteLine(HikmetinMarketi.CalcNotebookAvg());
            Console.WriteLine(HikmetinMarketi.CalcPhoneAvg());

        }
    }
}
