using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_05_19_ITKarieri_VendingMachine_ExamPreparation
{
    class VendingMachine
    {
        //полета на класа VendingMachine
        //Всяка машина има: id, списък от продукти, обща стойност на продажбите, батерия.
        private string id;
        private List<Product> products;
        private double totalSalesAmount;
        private double battery;

        //този конструктор трябва да приема id.
        public VendingMachine(string id)
        {
            this.Id = id;
            this.products = new List<Product>();
            this.totalSalesAmount = 0;
            this.battery = 100;
        }

        //този конструктор трябва да приема id и списък от продукти.
        public VendingMachine(string id, List<Product> products) : this(id)
        {
            this.products = products;
        }

        public string Id
        {
            get { return this.id; }
            //ID на вендинг машина трябва да бъде текст, 
            //съставен само от малки букви и с дължина по-голяма от 3 символа, ако не - Invalid machine id!
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

        //Презареждане на машината – нивото на батерията се вдига до първоначалната си стойност – 100 единици.
        public void Recharge()
        {
            this.Battery = 100;
        }

        //Стойността на продажбите следва да бъде занулена
        public void ClearSales()
        {
            this.TotalSalesAmount = 0;
        }

        //Следва да се отпечата точния брой на продукти от определен тип в дадената машина
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

        //Тази команда добавя продукт към дадената машина
        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        //Командата премахва продукт с даденото име от машината със съответното id.
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

        //Изпечатва се най-скъпият продукт, 
        //наличен в машината със съответното id. Гарантира се, че няма да има два продукта с еднакви цени.
        public Product GetMostExpensiveProduct()
        {
            return products.OrderByDescending(p => p.Price).ToList().FirstOrDefault();
        }

        /// <summary>
        /// Продажба на продукт. При всяка продажба нивото на батерията намалява. 
        /// Стойността, с която се намалява, е равна на цената на продукта  * 0.8 + 2. 
        /// От списъка с продукти премахнете продаденото. 
        /// Увеличете броя на тоталните продажби на продукти през класа Product с една единица, 
        /// към TotalSalesAmount добавете стойността на продукта.
        ///Важно: Трябва да се уверите, че разполагате с достатъчно батерия.
        ///В случай, че нивото е по-ниско, продажбата не се осъществява. 
        ///Допълнително пояснения – в секцията за Валидации.

        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public string SellProduct(string productName)
        {
            string result = "";
            //цената на продукта  * 0.8 + 2
            for (int i = 0; i < products.Count; i++)
            {
                //SaleProduct – Валидацията, следва да проверява дали има 
                //достатъчно батерия, ако няма изведете съобщение, ако не - Out of battery!
                if (this.Battery - products[i].Price * 0.8 + 2 > 0)
                {
                    if (products[i].Name.Equals(productName))
                    {
                        //При всяка продажба нивото на батерията намалява.
                        //Стойността, с която се намалява, е равна на цената на продукта  * 0.8 + 2. 
                        this.Battery -= products[i].Price * 0.8 + 2;
                        //Увеличете броя на тоталните продажби на продукти през класа Product с една единица, 
                        Product.IncreaseOrdersCount();
                        //към TotalSalesAmount добавете стойността на продукта.
                        this.TotalSalesAmount += products[i].Price;
                        result = string.Format("{0} for {1:f2}lv", products[i].Name, products[i].Price);
                        //От списъка с продукти премахнете продаденото. 
                        this.products.Remove(products[i]);
                    }
                }
                //В случай, че нивото е по-ниско, продажбата не се осъществява. 
                //Хвърля изключение ArgumentException със съобщение Out of battery
                else
                {
                    throw new ArgumentException("Out of battery!");
                }
            }

            return result;
        }

        //Премахват се всички налични продукти от машината, които отговарят на посочения тип.
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

        //Изпечатва се информация за всички продукти от съответната машина. 
        //Следва да подредите продуктите по брой в нарастващ ред и след 
        //това по тип по азбучен ред. За всеки тип се изпечатва следният текст на нов ред –
       //Type: <ProductsType> has total of - <Брой продукти от този тип> products.
        public string GetInfoAboutAllProductsByType()
        {
            //в речника пазим за ключ типа на продукта и за стойност на ключа запазваме броя продукти от този тип
            Dictionary<string, int> prodTypes = new Dictionary<string, int>();
            StringBuilder result = new StringBuilder();

            foreach (var product in products)
            {
                if (!prodTypes.ContainsKey(product.Type))
                {
                    //добавяме в речника
                    prodTypes.Add(product.Type, 0);
                }
                //увеличаваме броя на продукта от този тип
                prodTypes[product.Type] += 1;
            }

            //сортираме стойностите на речника във възходящ ред(което ни е броя продукти от дадения тип)
            //след което сортираме типовете(ключовете на речника) продукти по азбучен ред
            foreach (var kvp in prodTypes.OrderBy(p => p.Value).ThenBy(p => p.Key))
            {
                result.AppendFormat("Type: {0} has total of - {1} products.{2}"
                    , kvp.Key, kvp.Value, Environment.NewLine);
            }

            return result.ToString();
        }

        /// <summary>
        /// PrintMachineInfo<ID> - отпечатва информация за машина във формат:

        /// Machine: <ID> has the following available products:
        ///Product with type - <ProductType> and name - <ProductName>
        ///Product with type - <ProductType> and name - <ProductName>
        ///…/всички налични продукти, в реда, в който са постъпили в машината/
        ///---- With total sales amount: <TotalSalesAmount>.

        ///Тази команда ще получава винаги валидни и съществуващи имена на машини.
        ///За успешна реализация трябва да реализирате ваша версия на ToString() метода
        ///за класа VendingMachine.Всички продукти трябва да бъдат изпечатани по дадения формат 
        ////ToString() на всеки от тях/, в реда, в който са постъпили в машината. Oчаква се 
        ///обема на всички продажби да бъде форматиран до два знака след десетичния разделител.

        /// </summary>
        /// <returns></returns>
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
