using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_17HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //первый счёт - ввод данных
            BankAccount<string> account1 = new BankAccount<string>();
            string numberAcc1 = "420MLG";
            account1.SetNumber(numberAcc1);
            double balanceAcc1 = 1337.69;
            account1.SetBalance(balanceAcc1);
            string nameAcc1 = "Тащилов Ваншот Ваншотович";
            account1.SetOwnerName(nameAcc1);

            //первый счёт - вывод данных
            Console.WriteLine("Номер счёта: {0}\nБаланс: {1}\nФИО: {2}", account1.GetNumber(), account1.GetBalance(), account1.GetOwnerName());
            Console.WriteLine();

            //второй счёт - ввод данных
            BankAccount<string> account2 = new BankAccount<string>();
            string numberAcc2 = "013FRD";
            account2.SetNumber(numberAcc2);
            double balanceAcc2 = 735015.05;
            account2.SetBalance(balanceAcc2);
            string nameAcc2 = "Кристалозёров Джейсон Хоккеевич";
            account2.SetOwnerName(nameAcc2);

            //второй счёт - вывод данных
            Console.WriteLine("Номер счёта: {0}\nБаланс: {1}\nФИО: {2}", account2.GetNumber(), account2.GetBalance(), account2.GetOwnerName());
            Console.WriteLine();

            //третий счёт - ввод данных
            BankAccount<string> account3 = new BankAccount<string>();
            string numberAcc3 = "666HEL";
            account3.SetNumber(numberAcc3);
            double balanceAcc3 = 666.66;
            account3.SetBalance(balanceAcc3);
            string nameAcc3 = "Сатанинский Черт Люциферович";
            account3.SetOwnerName(nameAcc3);

            //третий счёт - вывод данных
            Console.WriteLine("Номер счёта: {0}\nБаланс: {1}\nФИО: {2}", account3.GetNumber(), account3.GetBalance(), account3.GetOwnerName());
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        //Закрытые поля
        private T AccNumber; // Тип номера счета определяется через универсальный параметр Т
        private double AccBalance;
        private string AccOwnerName;

        //Методы заполнения и чтения данных
        public void SetNumber(T number)
        {
            AccNumber = number;
        }
        public void SetBalance(double balance)
        {
            AccBalance = balance;
        }
        public void SetOwnerName(string name)
        {
            AccOwnerName = name;
        }

        public T GetNumber()
        {
            return AccNumber;
        }
        public double GetBalance()
        {
            return AccBalance;
        }
        public string GetOwnerName()
        {
            return AccOwnerName;
        }

    }
}
