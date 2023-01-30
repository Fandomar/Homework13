using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class Entity:DB
    {
        public Entity(int id, string Name, string Status, DateTime RegDate, double Balance, int CreditRate, int DebetRate)
          : base(Name) { }
        public Entity(string Name)
          : base(Name) { }
        protected override int CreditRateCalc()
        {
            if (this.Status == "Normal" && this.Balance > 10000000) { return 8; }
            if (this.Status == "VIP" && this.Balance > 10000000) { return 9; }
            return 10;
        }
        protected override int DebetRateCalc()
        {
            if (this.Status == "Normal" && this.Balance > 10000000) { return 5; }
            if (this.Status == "VIP" && this.Balance > 10000000) { return 6; }
            return 4;
        }
    }
}
