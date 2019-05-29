using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Order
    {
        private int orderNumber;
        private List<Product> products;
        private static int ordersCount;

        public Order(int orderNumber, List<Product> products)
        {
            this.OrderNumber = orderNumber;
            this.products = products;
            Order.ordersCount++;
        }

        public int OrderNumber
        {
            get { return this.orderNumber; }
            private set
            {
                this.orderNumber = value;
            }
        }

        public static int OrdersCount
        {
            get { return Order.ordersCount; }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public double GetOrderTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }

        public double GetDiscountedProductsTotalPrice()
        {
            return this.products.Where(p => p.IsOnPromotion == true).Sum(p => p.Price);
        }

        public int GetDiscountedProductsCount()
        {
            int count = 0;
            foreach (Product product in products)
            {
                if (product.IsOnPromotion)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Order #{0} has the following products:", this.OrderNumber);
            foreach (Product product in products)
            {
                result.Append(Environment.NewLine);
                result.AppendFormat("### Product -> {0} with price {1:f2}. On promotion: {2}",
                    product.Name, product.Price, product.IsOnPromotion ? "YES" : "NO");                
            }
            return result.ToString();
        }
    }
}
