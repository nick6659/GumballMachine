using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine
{
    public class PaymentSystem
    {
        public decimal balance = 0;
        public bool transactionComplete = false;

        public void insertCoins(decimal amount, decimal priceOfGum)
        {
            balance += amount;
            checkPurchace(balance, priceOfGum);
        }

        public string checkPurchace(decimal currentBalance, decimal priceOfGum)
        {
            if (currentBalance >= priceOfGum)
            {
                transactionComplete = true;
                return "Thank you for your purchase!";
            }
            else
            {
                return "You have to put in 5 DKK";
            }
        }
    }
}
