using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountCard bronze = new DiscountCard(CardLevel.Bronze, "Bronze", 0);
            DiscountCard silver = new DiscountCard(CardLevel.Silver, "Silver", 650);
            DiscountCard gold = new DiscountCard(CardLevel.Gold, "Gold", 1500);

            CashRegister cashierIntern = new CashRegister();
            string purchaseInfo = cashierIntern.GetPurchaseInfo(bronze, 150);
            Console.WriteLine(purchaseInfo);
            purchaseInfo = cashierIntern.GetPurchaseInfo(silver, 850);
            Console.WriteLine(purchaseInfo);
            purchaseInfo = cashierIntern.GetPurchaseInfo(gold, 1300);
            Console.WriteLine(purchaseInfo);
        }
    }
}
