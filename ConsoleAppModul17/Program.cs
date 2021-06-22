using System;

namespace ConsoleAppModul17_SOLID
{
    class Program
    {
         static void Main(string[] args)
         { 
            var account = new Account { Balance = 500 };

            var calculateExec = new CalculateExe();

            while (true)
            {
                Console.WriteLine("Для расчета процентной ставки ОБЫЧНОГО аккаунта - введите 1, ЗАРПЛАТНОГО - введите 2:");

                var text = Console.ReadLine();

                if (text == "1")
                { account.Type = "Обычный"; }
                else if (text == "2")
                { account.Type = "Зарплатный"; }
                else
                {
                    account.Type = "Обычный";
                    Console.WriteLine("Введено некорректное значение. Расчет будет произведен по-умолчанию - для обычного аккаунта.");
                }
           
                if (account.Type == "Обычный")
                {
                    // загружаем в расчет обычный аккаунт 
                    calculateExec.AccountLanding(new CalculateSimple(), account);
                }
                else if (account.Type == "Зарплатный")
                {
                    //загружаем в расчет зарплатный аккаунт
                    calculateExec.AccountLanding(new CalculateSalary(), account);
                }

                Console.WriteLine();
            }
         }
     }
}
