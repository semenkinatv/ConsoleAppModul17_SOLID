using System;


namespace ConsoleAppModul17_SOLID
{
    public class CalculateSimple : ICalculate
    {
        // расчет процентной ставки обычного аккаунта по правилам банка
        public void  CalculateInterest(Account account)
        {
            //Логика расчета из Задания 4 Модуля 17.6:

            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
           
            Console.WriteLine($"\r\nВаш Баланс {account.Balance}.\r\nПроцентная ставка обычного аккаунта составила {account.Interest}");
        }
    }
}
