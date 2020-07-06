using System;

namespace MarketStore
{
    public class CashRegister
    {

        public string GetPurchaseInfo(DiscountCard discountCard, decimal purchaseAmount)
        {
            try
            {
                if (purchaseAmount <= 0)
                {
                    throw new Exception("Purchase minimum is $0.01");
                }

                string purchaseValueInfo = "Purchase value: " + purchaseAmount.ToString("$0.00");

                decimal discountRate = discountCard.InitialDiscountRate;
                string discountRateInfo = String.Format("Discount rate: {0:P1}", discountRate);

                decimal discountValue = purchaseAmount * discountRate;
                string discountValueInfo = "Discount: " + discountValue.ToString("$0.00");

                decimal total = purchaseAmount - discountValue;
                string totalInfo = "Total value: " + total.ToString("$0.00");
                return String.Format("{0} \n" + "{1} \n" + "{2} \n" + "{3} \n",
                                      purchaseValueInfo, discountRateInfo, discountValueInfo, totalInfo);
            }
            catch (Exception ex)
            {
                if (String.IsNullOrEmpty(ex.Message))
                {
                    return "Something went wrong, please contact your system administrator";
                }
                else return ex.Message;
            }
        }
    }
}
