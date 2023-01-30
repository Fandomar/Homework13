using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DB> db = new List<DB>();
            List<History> history = new List<History>();

            Console.WriteLine("Банковская система \"Наши деньги\"");
            Console.WriteLine($"Сумма на счетах банка:{BankBalance.GetDepositBalance()}");
            Console.WriteLine($"Сумма банковских кредитов:{BankBalance.GetCreditBalance()}");
            if (!BankBalance.GetBankStatus()) { Console.WriteLine("Вы банкрот!"); }

            Console.WriteLine("Возможные действия:");
            Console.WriteLine("1. Добавить клиента (физлицо): ");
            Console.WriteLine("2. Добавить клиента (юрлицо): ");
            Console.WriteLine("3. Выдать кредит: ");
            Console.WriteLine("4. Принять депозит: ");
            Console.WriteLine("5. Посмотреть историю клиента: ");
            switch (Convert.ToInt16(Console.ReadKey()))
            {
                case 1: db.Add(new Individual(Convert.ToString(Console.ReadLine())));
                        history.SetDiscriptionNewUser(db[Convert.ToInt32(db.LongCount()) - 1]); break;
                case 2: db.Add(new Entity(Convert.ToString(Console.ReadLine()))); break;
                case 3: break;
                case 4: break;
                case 5: break;


            }


        }
    }
}
