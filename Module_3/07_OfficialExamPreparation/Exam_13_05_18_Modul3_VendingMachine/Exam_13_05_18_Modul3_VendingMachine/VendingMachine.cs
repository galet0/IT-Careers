using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_13_05_2018_Modul3_VendingMachine
{
    class VendingMachine
    {
        private string id;
        private List<Product> products;
        private double totalSalesAmount;
        private double battery;

        //VendingMachine(string id) – този конструктор трябва да приема id.
        public VendingMachine(string id)
        {
            this.Id = id;
            this.Products = new List<Product>();
            this.Battery = 100;
        }

        //VendingMachine(string id, List<Product> products) - 
        //този конструктор трябва да приема id и списък от продукти.
        public VendingMachine(string id, List<Product> products) : this(id)
        {
            this.Products = products;
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (!value.ToLower().Equals(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid machine id!");
                }
                this.id = value;
            }
        }

        public List<Product> Products
        {
            get { return this.products; }
            set
            {
                this.products = value;
            }
        }

        public double TotalSalesAmount
        {
            get { return this.totalSalesAmount; }
            set
            {
                this.totalSalesAmount = value;
            }
        }

        public double Battery
        {
            get { return this.battery; }
            set
            {
                this.battery = value;
            }
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        public int CheckProductQuantityOfGivenType(string productType)
        {
            int quantity = 0;
            foreach (Product product in Products)
            {
                if (product.Type.Equals(productType))
                {
                    quantity += 1;
                }
            }

            return quantity;
        }

        public void RemoveProduct(string productName)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Name.Equals(productName))
                {
                    this.Products.Remove(Products[i]);
                }
            }
        }

        public Product GetMostExpensiveProduct()
        {
            return this.Products
                .OrderByDescending(p => p.Price)
                .ToList()
                .FirstOrDefault();
        }

        /// <summary>
        ///SellProduct <ID> <име на продукт> - Продажба на продукт. 
        ///1.При всяка продажба нивото на батерията намалява. 
        ///2.Стойността, с която се намалява, е равна на цената на продукта  * 0.8 + 2. 
        ///3.От списъка с продукти премахнете продаденото. 
        ///4.Увеличете броя на тоталните продажби на продукти през класа Product с една единица, 
        ///5.към TotalSalesAmount добавете стойността на продукта.
        ///6.Важно: Трябва да се уверите, че разполагате с достатъчно батерия.
        ///В случай, че нивото е по-ниско, продажбата не се осъществява. 
        ///Допълнително пояснения – в секцията за Валидации.
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public string SellProduct(string productName)
        {
            foreach (Product product in Products)
            {
                if (this.Battery - product.Price * 0.8 + 2 > 0)
                {
                    if (product.Name.Equals(productName))
                    {
                        this.Battery -= product.Price * 0.8 + 2;
                        this.TotalSalesAmount += product.Price;
                        this.Products.Remove(product);
                        Product.IncreaseOrdersCount();
                        return string.Format("{0} for {1}lv.", product.Name, product.Price);
                    }
                }
                else
                {
                    throw new ArgumentException("Out of battery!");
                }
            }

            return null;
        }

        public void RemoveAllProductsOfGivenType(string productType)
        {
            foreach (Product product in Products)
            {
                if (product.Type.Equals(productType))
                {
                    this.Products.Remove(product);
                }
            }
        }

        public string GetInfoAboutAllProductsByType()
        {
            //Type: <ProductsType> has total of - 
            //<Брой продукти от този тип> products.
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Product product in Products)
            {
                if (!dict.ContainsKey(product.Type))
                {
                    dict.Add(product.Type, 0);
                }

                dict[product.Type] += 1;
            }

            StringBuilder result = new StringBuilder();

            foreach (var kvp in dict.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                result.AppendFormat("Type: {0} has total of - {1} products.{2}", 
                    kvp.Key, kvp.Value, Environment.NewLine);
            }

            return result.ToString();
        }

        public void Recharge()
        {
            this.Battery = 100;
        }

        public void ClearSales()
        {
            this.TotalSalesAmount = 0;
        }

        public override string ToString()
        {
            //Machine: iddd has the following available products:
            //Product with type - SWEET and name -twix
            //Product with type - SWEET and name -kitkat
            //---- With total sales amount: 0.00.
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Machine: {0} has the following available products:{1}",
                this.Id, Environment.NewLine);
            foreach (Product product in Products)
            {
                result.AppendFormat("Product with type - {0} and name -{1}{2}",
                    product.Type, product.Name, Environment.NewLine);
            }

            result.AppendFormat("---- With total sales amount: {0:f2}.",
                this.TotalSalesAmount);
            return result.ToString();
        }
    }
}
