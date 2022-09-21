using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    internal class RealEstateSalesperson : Salesperson
    {

        private double totalValueSold = 0;
        private double totalCommissionEarned= 0;
        private double commissionRate;

        public double TotalValueSold
        { 
            get
            { return totalValueSold; } 
            set 
            { totalValueSold = value; }
        }
        public double TotalCommissionEarned 
        { 
            get 
            { return totalCommissionEarned; }
            set 
            { totalCommissionEarned = value; }
        }
        public double CommissionRate
        {
            get
            { return commissionRate; }
            set
            { commissionRate = value; }
        }

        public RealEstateSalesperson(string firstName, string lastName, double commissionRate) : base(firstName, lastName)
        {
            CommissionRate=commissionRate;
        }
        public void SalesSpeech()
        {
            Console.WriteLine("Our moto is 100% reliability and our realestate company provide you closest option for your desirable house.");
        }
        public void MakeSale(int value)
        {
            totalValueSold += value;
            totalCommissionEarned = totalValueSold * commissionRate;
            Console.WriteLine($"total value sold: {totalValueSold:c}, total commission earned: {totalCommissionEarned:c}");
        }
    }
}
