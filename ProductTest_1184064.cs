using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1184064
{
        class ProductTest_1184064
    {
        static void Main(string[] args)
        {
            Book_1184064 product1 = new Book_1184064("Book", "C# Object Oriented Solution", "300");
            DVD_1184064 product2 = new DVD_1184064("Eternal Sunshine of The Spotlees MInd", "145");


            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minute duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}