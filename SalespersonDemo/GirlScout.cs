using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    internal class GirlScout : Salesperson
    {
        private int numberBoxSold = 0;

        public int NumberBoxSold 
        { 
            get 
            { return numberBoxSold; } 
            set 
            { numberBoxSold = value; } 
        }
        public GirlScout(string firstName, string lastName) : base(firstName, lastName) { }
      
        public void SalesSpeech()
        {
            Console.WriteLine("Our cookie is 100% organic and we donate 10% of sale to Homeless care facility");
        }
        public void MakeSale(int numBox)
        {
            numberBoxSold += numBox;
            Console.WriteLine($"The total number of boxes of cokies: {numberBoxSold}");
        }
    }
}
