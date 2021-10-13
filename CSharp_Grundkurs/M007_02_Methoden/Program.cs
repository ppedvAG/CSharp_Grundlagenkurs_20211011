using System;

namespace M007_02_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(12345, "Andre", 50000, -100000);
            bankAccount.Einzahlen(333);
            bankAccount.Einzahlen(222);
            bankAccount.Einzahlen(111);
            bankAccount.Einzahlen(111);

            bankAccount.Auszahlen(20000);
            bankAccount.Einzahlen(1);

            bankAccount.DisplayAccount();
            bankAccount.DisplayAccountHistory();



            //Ganz Böser Code
            //bankAccount.KontoHistory.Add(bankAccount.Value);
        }
    }
}
