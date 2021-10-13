using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_02_Methoden
{
    /// <summary>
    /// Hier handelt es sich um ein Bankkonto 
    /// </summary>
    public class BankAccount
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public decimal Dispo { get; set; }
        public string Owner { get;  set; } //Vor und Nachname 


        public List<decimal> KontoHistory;

        public BankAccount()
        {
            this.Dispo = -1000;
            this.KontoHistory = new List<decimal>(); //Bauen eine Liste im Arbeitspeicher auf
        }

        public BankAccount(int id, string owner, decimal moneyValue)
            :this()
        {
            this.Id = id;
            this.Value = moneyValue;
            this.Owner = owner;


        }

        public BankAccount(int id, string owner, decimal moneyValue, decimal dispo)
        {
            this.Id = id;
            this.Value = moneyValue;
            this.Owner = owner;
            this.Dispo = dispo;

            this.KontoHistory = new List<decimal>();
        }

        public void Einzahlen(decimal betrag)
        {
            Value += betrag;
            AddAccountValueToHistory(Value);
        }

        public void Auszahlen (decimal betrag)
        {
            if ((Value - betrag) < Dispo)
                throw new Exception("Dispo kann nicht überzogen werden");

            Value -= betrag; //Value=Value-betrag
            AddAccountValueToHistory(Value);
        }

        private void AddAccountValueToHistory(decimal currentValue)
        {
            KontoHistory.Add(Value);
        }



        public void DisplayAccount()
        {
            Console.WriteLine(this.Value);
        }

        public void DisplayAccountHistory()
        {
            foreach (decimal currentValue in KontoHistory)
                Console.WriteLine(currentValue);
        }
    }
}
