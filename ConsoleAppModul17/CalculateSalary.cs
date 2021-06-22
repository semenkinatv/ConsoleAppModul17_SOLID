using System;

namespace ConsoleAppModul17_SOLID
{
    public class CalculateSalary : ICalculate
    {
        // расчет процентной ставки зарплатного аккаунта по правилам банка

        public void CalculateInterest(Account account)
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
            Console.WriteLine($"\r\nВаш Баланс {account.Balance}.\r\nПроцентная ставка зарплатного аккаунта составила {account.Interest}");
        }
    }
}
