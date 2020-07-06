namespace MarketStore
{

    public enum CardLevel { Bronze, Silver, Gold }
    public class DiscountCard
    {
        public CardLevel CardLevel { get; set; }
        public string CardOwnerInfo { get; set; }
        public decimal LastMonthTurnover { get; set; }
        public decimal InitialDiscountRate { get; set; }
        public DiscountCard(CardLevel level, string cardOwnerInfo, decimal lastMonthTurnover)
        {
            CardLevel = level;
            CardOwnerInfo = cardOwnerInfo;
            LastMonthTurnover = lastMonthTurnover;
            InitialDiscountRate = CalculateDiscount(lastMonthTurnover, level);
        }

        decimal CalculateDiscount(decimal turnover, CardLevel level)
        {
            decimal discount;
            switch (level)
            {
                case CardLevel.Bronze:

                    if (turnover > 300)
                    {
                        discount = 0.025m;
                    }
                    else if (turnover >= 100)
                    {
                        discount = 0.01m;
                    }
                    else discount = 0.00m;
                    break;
                case CardLevel.Silver:
                    discount = turnover > 300 ? 0.035m : 0.02m;
                    break;
                case CardLevel.Gold:
                    discount = 0.02m;
                    int hundredsSpent = (int)turnover / 100;
                    decimal neki = ((decimal)hundredsSpent) / 100;
                    discount = (discount + neki) < 0.1m ? (discount + neki) : 0.1m;
                    break;
                default:
                    discount = 0.00m;
                    break;
            }

            return discount;
        }
    }
}
