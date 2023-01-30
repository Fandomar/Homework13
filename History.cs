using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework13
{
    internal class History
    {
        static private int RecordNumber { get; set; } 
        private int Id { get; set; }
        private string Name { get; set; }
        private DateTime RecordDate { get; set; }
        private string Description { get; set; }
        private double Balance { get; set; }

        static History()
        {
            RecordNumber = 0;
        }
        private static int NextRecordNumber() { return RecordNumber + 1; }
        public History(string Name, string Description, double Balance)
        {
            this.Id = NextRecordNumber();
            this.Name = Name;
            this.RecordDate = DateTime.Now;
            this.Description = Description;
            this.Balance = Balance;
        }
        public History SetDiscriptionNewUser(DB db)
        { 
            History history= new History(db.GetName(),  $"{db.GetName()} opened an account.", db.GetBalance());            
            return history;
        }
        public History SetDiscriptionNewCredit(DB db, double Credit)
        {
            History history = new History(db.GetName(), $"{db.GetName()} took a loan of {Credit}.", db.GetBalance());
            return history;
        }
        public History SetDiscriptionNewDebet(DB db, double Debet)
        {
            History history = new History(db.GetName(), $"{db.GetName()} made a deposit of {Debet}.", db.GetBalance());
            return history;
        }
    }
}
