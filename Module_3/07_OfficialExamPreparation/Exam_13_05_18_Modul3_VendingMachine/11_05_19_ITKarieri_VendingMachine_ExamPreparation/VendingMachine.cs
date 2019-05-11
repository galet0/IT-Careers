using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_05_19_ITKarieri_VendingMachine_ExamPreparation
{
    class VendingMachine
    {
        private string id;
        private List<Product> products;
        private double totalSalesAmount;
        private double battery;

        public VendingMachine(string id)
        {
            this.Id = id;
            this.products = new List<Product>();
            this.totalSalesAmount = 0;
            this.battery = 100;
        }

        public VendingMachine(string id, List<Product> products) : this(id)
        {
            this.products = products;
        }

        public string Id
        {
            get { return this.id; }
            private set
            {
                if (string.IsNullOrEmpty(value)
                    || string.IsNullOrWhiteSpace(value)
                    || value.Length < 4
                    || !value.ToLower().Equals(value))
                {
                    throw new ArgumentException("Invalid machine id!");
                }

                this.id = value;
            }
        }

        public double Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }

        public double TotalSalesAmount
        {
            get { return this.totalSalesAmount; }
            private set
            {
                this.totalSalesAmount = value;
            }
        }

        public void Recharge()
        {
            this.Battery = 100;
        }

        public void ClearSales()
        {
            this.totalSalesAmount = 0;
        }

        public int CheckProductQuantityOfGivenType(string type)
        {
            int quantity = 0;
            foreach (var product in products)
            {
                if (product.Type.Equals(type))
                {
                    quantity++;
                }
            }

            return quantity;
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(string productName)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.Equals(productName))
                {
                    products.Remove(products[i]);
                }
            }
        }

        public Product GetMostExpensiveProduct()
        {
            return products.OrderByDescending(p => p.Price).ToList().FirstOrDefault();
        }

        public string SellProduct(string productName)
        {
            string result = "";
            //цената на продукта  * 0.8 + 2
            for (int i = 0; i < products.Count; i++)
            {
                if(this.Battery - products[i].Price * 0.8 + 2 > 0)
                {
                    if (products[i].Name.Equals(productName))
                    {
                        this.Battery -= products[i].Price * 0.8 + 2;                        
                        Product.IncreaseOrdersCount();
                        this.TotalSalesAmount += products[i].Price;
                        result = string.Format("{0} for {1:f2}lv", products[i].Name, products[i].Price);
                        this.products.Remove(products[i]);
                    }
                }
                else
                {
                    throw new ArgumentException("Out of battery!");
                }
            }

            return result;
        }

        public void RemoveAllProductsOfGivenType(string productType)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Type.Equals(productType))
                {
                    products.Remove(products[i]);
                }
            }
        }

        public string GetInfoAboutAllProductsByType()
        {
            Dictionary<string, int> prodTypes = new Dictionary<string, int>();
            StringBuilder result = new StringBuilder();

            foreach (var product in products)
            {
                if (!prodTypes.ContainsKey(product.Type))
                {
                    prodTypes.Add(product.Type, 0);
                }

                prodTypes[product.Type] += 1;
            }

            foreach (var kvp in prodTypes.OrderBy(p => p.Value).ThenBy(p => p.Key))
            {
                result.AppendFormat("Type: {0} has total of - {1} products.{2}"
                    , kvp.Key, kvp.Value, Environment.NewLine);
            }

            return result.ToString();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Machine: {0} has the following available products:", this.Id);
            foreach (var product in products)
            {
                result.AppendFormat("{0}{1}", Environment.NewLine, product);
            }
            result.Append(Environment.NewLine);
            result.AppendFormat("---- With total sales amount: {0:f2}.", this.TotalSalesAmount);
            return result.ToString();
        }
    }
}
