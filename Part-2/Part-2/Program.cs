using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct herbalProduct = new HerbalProduct();

            // Set common product information
            herbalProduct.SetInformation(1, "Herbal Shampoo", 10.99);

            // Set Herbal Product information
            herbalProduct.SetHerbalProductDetails("Aloe Vera, Lavender", DateTime.Parse("2023-01-01"), DateTime.Parse("2024-01-01"));

            // Display details
            herbalProduct.ShowDetails();
        }
    }
}
