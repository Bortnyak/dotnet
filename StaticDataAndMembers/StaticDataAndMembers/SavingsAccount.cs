﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;
 
        //Статический элемент данных.
        public static double currentInterestRate;

        //Конструктор устанавливает значение статического поля currInterestRete.
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        //Статический конструктор
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currentInterestRate = 0.04; //Статические данные!
        }

        //Статические члены для установки/получения процентной ставки
        public static void SetInterestRate(double newRate)
        {
            currentInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currentInterestRate;
        }
        
    }
}
