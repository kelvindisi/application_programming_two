using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingProgram
{
    class Saving
    {
        private double saving, amount = 0;
        private int annualRate, months;

        public double P_Saving
        {
            get { return saving; }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("Saving must be 100 and above.");
                    value = 100;
                }
                saving = value;
            }
        }

        public Saving()
        {
            P_Saving = 50;
            annualRate = 1;
            months = 1;
        }
        public Saving(double saving, int annualRate, int months)
        {
            this.P_Saving = saving;
            this.annualRate = annualRate;
            this.months = months;
        }
        public void input()
        {
            Console.WriteLine("Enter saving amount: ");
            P_Saving = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter annual rate: ");
            annualRate = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of months to save: ");
            months = Int32.Parse(Console.ReadLine());
        }

        public void compute()
        {
            double mRate;
            int i;
            mRate = (annualRate / 100.00) / 12;

            for (i=1; i<=months; i++)
            {
                amount = (P_Saving + amount) * (1 + mRate);
            }
        }
        
        public void display()
        {
            Console.WriteLine("Saving: {0} for {1} months will amount to {2}", P_Saving, months, amount);
        }
    }
}
