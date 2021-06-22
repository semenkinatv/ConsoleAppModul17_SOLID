using System;

namespace ConsoleAppModul17_SOLID
{
    class CalculateExe
    {
         /// <summary>
        /// Запускает расчет. Загружает аккаунт в виде аргумента
        /// </summary>
        /// 
        public void AccountLanding(ICalculate calculate, Account acc)
        {
            calculate.CalculateInterest(acc);
        }
    }
}
