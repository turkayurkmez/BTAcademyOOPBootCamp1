namespace OpenClosed
{
    /*
     * Open Closed Principle:
     * Bir nesne gelişime AÇIK değişime KAPALI olmalı...
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Name = "Hale", Cart = new Premium() };
            OrderManager orderManager = new OrderManager { Customer = customer };

            var discountedPrice = orderManager.GetDiscountedPrice(1000);
            Console.WriteLine(discountedPrice);


        }
    }


    //public enum CartType
    //{
    //    Standart,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class Cart
    {
        public abstract decimal Discounted(decimal total);

    }

    public class Standart : Cart
    {
        public override decimal Discounted(decimal total)
        {
            return total * .95M;
        }
    }

    public class Silver : Cart
    {
        public override decimal Discounted(decimal total)
        {
            return total * .9M;
        }
    }

    public class Gold : Cart
    {
        public override decimal Discounted(decimal total)
        {
            return total * .85M;
        }
    }

    public class Premium : Cart
    {
        public override decimal Discounted(decimal total)
        {
            return total * .75M;
        }
    }

    public class Customer
    {
        public Cart Cart { get; set; }
        public string Name { get; set; }
    }

    public class OrderManager
    {
        public Customer Customer { get; set; }
        public decimal GetDiscountedPrice(decimal totalPrice)
        {
            return Customer.Cart.Discounted(totalPrice);

            //switch (Customer.Cart)
            //{
            //    case CartType.Standart:
            //        return totalPrice * 0.95m;
            //    case CartType.Silver:
            //        return totalPrice * 0.9M;
            //    case CartType.Gold:
            //        return totalPrice * 0.85M;
            //    case CartType.Premium:
            //        return totalPrice * 0.75M;

            //    default:
            //        return totalPrice;
            //}
        }
    }
}

