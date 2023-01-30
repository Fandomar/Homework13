using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    abstract class DB
    {
        static int staticId { get; set; }

        protected int Id;
        protected string Name { get; set; }
        protected string Status { get; set; }
        protected DateTime RegDate { get; set; }
        protected int CreditRate { get; set; }
        protected int DebetRate { get; set; }
        protected double Balance { get; set; }
        static DB() { staticId = 0;}
        private static int NextId() {return staticId + 1;}
        public DB(string Name) 
        { 
            this.Id= NextId();
            this.Name= Name;
            this.Status = "Normal";
            this.RegDate = DateTime.Now;
            this.CreditRate = 10;
            this.DebetRate= 4;
            this.Balance = 0;
        }
        public string GetName() { return this.Name; }
        public double GetBalance() { return this.Balance; }
        protected virtual int CreditRateCalc() { return CreditRate; }
        protected virtual int DebetRateCalc() { return DebetRate; }


    }
}
