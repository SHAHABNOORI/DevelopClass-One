using StrategyPattern.Pattern;

namespace StrategyPattern.Models
{
    public class Order
    {
        public int Price { get; set; }

        public Customer Customer { get; set; }

        public CalculateFinalPrice CalculateFinalPrice { get; set; }

        public Order(int price, Customer customer)
        {
            Price = price;
            Customer = customer;
        }

        public Order(int price, Customer customer, CalculateFinalPrice calculateFinalPrice)
        {
            Price = price;
            Customer = customer;
            CalculateFinalPrice = calculateFinalPrice;
        }

        public int GetFinalInLegacyWay()
        {
            switch (Customer.Type)
            {
                case CustomerType.Gold:
                    return Price - (Price / 100 * 30);

                case CustomerType.Silver:
                    return Price - (Price / 100 * 20);

                case CustomerType.Bronze:
                    return Price - (Price / 100 * 10);

                case CustomerType.Iron:
                    return Price - (Price / 100 * 5);

                default:
                    return Price;
            }
        }

        public int GetFinalUsingPattern()
        {
            return CalculateFinalPrice.Calculate(Price);
        }
    }
}