namespace Exam_13_05_2018_Modul3_VendingMachine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static Dictionary<string, Product> products = new Dictionary<string, Product>();
        private static Dictionary<string, VendingMachine> machines = new Dictionary<string, VendingMachine>();

        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    //създава продукт
                    case "CreateProduct": // OK
                        CreateProduct(commandArgs.Skip(1).ToArray());
                        break;
                    //създава вендинг машина
                    case "CreateVendingMachine": // OK
                        CreateVendingMachine(commandArgs.Skip(1).ToArray());
                        break;
                    case "RechargeMachine": // OK
                        RechargeMachine(commandArgs.Skip(1).ToArray());
                        break;
                    case "ClearMachineSales": // OK
                        ClearMachineSales(commandArgs.Skip(1).ToArray());
                        break;
                    case "AddProductToMachine": // OK
                        AddProductToMachine(commandArgs.Skip(1).ToArray());
                        break;
                    case "CheckProductQuantity": //OK
                        CheckProductQuantity(commandArgs.Skip(1).ToArray());
                        break;
                    case "RemoveProduct": // OK
                        RemoveProductByName(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetMostExpensiveProduct": // OK 
                        GetMostExpensiveProduct(commandArgs.Skip(1).ToArray());
                        break;
                    case "SellProduct": // OK
                        SellProduct(commandArgs.Skip(1).ToArray());
                        break;
                    case "PrintMachineInfo": // OK
                        PrintMachineInfo(commandArgs.Skip(1).ToArray());
                        break;
                    case "PrintProductInfo": // OK
                        PrintProductInfo(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetBatteryLevelOfMachine": // OK
                        GetBatteryLevelOfMachine(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetMachineTotalSalesAmount": // OK
                        GetMachineTotalSalesAmount(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetTotalProductSales": // OK
                        GetTotalProductSales(commandArgs.Skip(1).ToArray());
                        break;
                    case "RemoveAllProductsOfGivenType": // OK
                        RemoveAllProductsOfGivenType(commandArgs.Skip(1).ToArray());
                        break;
                    case "PrintInfoAboutAllProductsByType": // OK
                        PrintInfoAboutAllProductsByType(commandArgs.Skip(1).ToArray());
                        break;
                }
            }
        }
        /// <summary>
        /// Вашето приложение трябва да изпълнява следната команда за добавяне на продукти:
        ///CreateProduct<тип>  <име>  <цена> - тази команда има за цел да добави продукт 
        ///с неговия тип, име и цена.
        /// </summary>
        /// <param name="args"></param>
        private static void CreateProduct(string[] args)
        {
            try
            {
                Product product = new Product(args[0], args[1], double.Parse(args[2]));
                products.Add(product.Name, product);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// CreateVendingMachine <id> - тази команда има за цел да създаде машина с даденото ID.
        /// CreateVendingMachine <id, списък от продукти>- 
        /// тази команда има за цел да създаде машина с даденото ID и списък от продукти.
        /// </summary>
        /// <param name="args"></param>
        private static void CreateVendingMachine(string[] args)
        {
            VendingMachine vendingMachine = null;
            //Проверява дали получава един параметър(само id на машината)
            if (args.Length == 1)
            {
                try
                {
                    vendingMachine = new VendingMachine(args[0]);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //или получава освен id на машината, също и списък с продукти
            else
            {
                List<Product> currentProducts = new List<Product>();
                foreach (var p in args.Skip(1))
                {
                    currentProducts.Add(products[p]);
                }
                try
                {
                    vendingMachine = new VendingMachine(args[0], currentProducts);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (vendingMachine != null)
            {
                machines.Add(vendingMachine.Id, vendingMachine);
            }
        }

        /// <summary>
        /// RechargeMachine <ID> - Презареждане на машината – 
        /// нивото на батерията се вдига до първоначалната си стойност – 100 единици.
        /// </summary>
        /// <param name="args"></param>
        private static void RechargeMachine(string[] args)
        {
            machines[args[0]].Recharge();
        }

        /// <summary>
        /// ClearMachineSales <ID> - Стойността на продажбите следва да бъде занулена.
        /// </summary>
        private static void ClearMachineSales(string[] args)
        {
            machines[args[0]].ClearSales();
        }

        /// <summary>
        /// AddProductToMachine <ID> <име на продукт> -Тази команда добавя продукт към дадената машина
        /// </summary>
        /// <param name="args"></param>
        private static void AddProductToMachine(string[] args)
        {
            machines[args[0]].AddProduct(products[args[1]]);
        }

        /// <summary>
        /// CheckProductQuantity <ID> <тип продукт> - 
        /// Следва да се отпечата точния брой на продукти от определен тип в дадената машина.
        /// </summary>
        /// <param name="args"></param>
        private static void CheckProductQuantity(string[] args)
        {
            Console.WriteLine(machines[args[0]].CheckProductQuantityOfGivenType(args[1]));
        }

        /// <summary>
        /// RemoveProductByName <ID> <име на продукт> - 
        /// Командата премахва продукт с даденото име от машината със съответното id.
        /// </summary>
        /// <param name="args"></param>
        private static void RemoveProductByName(string[] args)
        {
            machines[args[0]].RemoveProduct(args[1]);
        }

        /// <summary>
        /// GetMostExpensiveProduct <ID> <име на продукт> - 
        /// Изпечатва се най-скъпият продукт, наличен в машината със 
        /// съответното id. Гарантира се, че няма да има два продукта с еднакви цени.
        /// </summary>
        /// <param name="args"></param>
        private static void GetMostExpensiveProduct(string[] args)
        {
            Product product = machines[args[0]].GetMostExpensiveProduct();
            Console.WriteLine($"Machine's with ID = {machines[args[0]].Id} most expensive product is: {product}");
        }
        //SellProduct <ID> <име на продукт> - Продажба на продукт. 
        private static void SellProduct(string[] args)
        {
            try
            {
                Console.WriteLine($"Machine's with ID = {machines[args[0]].Id} " +
                    $"sold {machines[args[0]].SellProduct(args[1])}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// PrintMachineInfo<ID> - отпечатва информация за машина във формат:
        /// Machine: <ID> has the following available products:
        ///Product with type - <ProductType> and name - <ProductName>
        ///Product with type - <ProductType> and name - <ProductName>
        ///всички налични продукти, в реда, в който са постъпили в машината/
        ///---- With total sales amount: <TotalSalesAmount>.

        /// За успешна реализация трябва да реализирате ваша версия на ToString() 
        /// метода за класа VendingMachine. 
        /// </summary>
        /// <param name="args"></param>
        private static void PrintMachineInfo(string[] args)
        {
            Console.WriteLine(machines[args[0]]);
        }
        /// <summary>
        ///PrintProductInfo <име> - отпечатва информация за продукт във формат:
        ///Product with type - <тип> and name - <име>
        ///Тази команда ще получава винаги валидни и съществуващи имена на продукти.
        ///За успешна реализация трябва да реализирате ваша версия на ToString() 
        ///метода за класа Product.
        /// </summary>
        /// <param name="args"></param>
        private static void PrintProductInfo(string[] args)
        {
            Console.WriteLine(products[args[0]]);
        }

        /// <summary>
        /// GetBatteryLevelOfMachine <ID> - 
        /// Изпечатва се текущото ниво на батерията на дадената машина
        /// </summary>
        /// <param name="args"></param>
        private static void GetBatteryLevelOfMachine(string[] args)
        {
            Console.WriteLine($"Machine's with ID = {machines[args[0]].Id} has battery level = {machines[args[0]].Battery:F2}");
        }

        /// <summary>
        /// GetMachineTotalSalesAmount<ID> - 
        /// Изпечатва се текущия обем на продажбите на дадената машина
        /// </summary>
        /// <param name="args"></param>
        private static void GetMachineTotalSalesAmount(string[] args)
        {
            Console.WriteLine($"{machines[args[0]].TotalSalesAmount:F2}");
        }

        //GetTotalProductSales - Изпечатва общият брой на продадени продукти
        private static void GetTotalProductSales(string[] args)
        {
            Console.WriteLine(Product.OrdersCount);
        }

        //Bonus
        /// <summary>
        /// RemoveAllProductsOfGivenType <ID> <тип продукт> - 
        /// Премахват се всички налични продукти от машината, които отговарят на посочения тип.
        /// </summary>
        /// <param name="args"></param>
        private static void RemoveAllProductsOfGivenType(string[] args)
        {
            machines[args[0]].RemoveAllProductsOfGivenType(args[1]);
        }

        // Bonus
        /// <summary>
        /// PrintInfoAboutAllProductsByType<ID> -  
        /// Изпечатва се информация за всички продукти от съответната машина. 
        /// Следва да подредите продуктите по брой в нарастващ ред и след 
        /// това по тип по азбучен ред. За всеки тип се изпечатва следният текст на нов ред –
        ///Type: <ProductsType> has total of - <Брой продукти от този тип> products.
        /// </summary>
        /// <param name="args"></param>
        private static void PrintInfoAboutAllProductsByType(string[] args)
        {
            Console.Write(machines[args[0]].GetInfoAboutAllProductsByType());
        }
    }
}
