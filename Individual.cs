using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class Individual:DB
    {
        public Individual(int id, string Name, string Status, DateTime RegDate, double Balance, int CreditRate, int DebetRate)
            : base(Name) { }
        public Individual(string Name)
            : base(Name) { }
        protected override int CreditRateCalc() 
        { 
            if (this.Status == "Normal" && this.Balance > 10000) { return 9; }
            if (this.Status == "VIP" && this.Balance > 0) { return 8; }
            if (this.Status == "VIP" && this.Balance > 10000) { return 7; }
            return 10; 
        }
        protected override int DebetRateCalc()
        {
            if (this.Status == "Normal" && this.Balance > 10000) { return 5; }
            if (this.Status == "VIP" && this.Balance > 0) { return 6; }
            if (this.Status == "VIP" && this.Balance > 10000) { return 7; }
            return 4;
        }
    }
}
