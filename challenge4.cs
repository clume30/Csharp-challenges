using System;
using System.Linq;

namespace challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            Console.Write("what is the SKU value of what you bought: ");
            string sku = Console.ReadLine(); // stores the SKU values

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            // first part of the product 
            switch(product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T - Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                case "04":
                    type = "Trousers";
                    break;
            }
            // second part of the product
            switch(product[1])
            {
                case "Bk":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                case "WE":
                    color = "White";
                    break;
            }
            // third part of the product
            switch(product[2])
            {
                case "L":
                    size = "Large";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "N":
                    size = "Small";
                    break;
            }

            Console.WriteLine($"Product: {type} {color} {size}");
        }
    }
}