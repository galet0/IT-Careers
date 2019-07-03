using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_ExamPreparation_Restaurant
{
    class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public Fridge()
        {

        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public void AddProduct(string productName)
        {
            Product product = new Product(productName);

            if (this.Count == 0)
            {
                this.head = product;
                this.tail = product;
            }
            else
            {

                this.tail.Next = product;
                this.tail = product;
            }

            this.Count++;
        }

        public string[] CookMeal(int start, int end)
        {
            /*if (this.count == 0)
            {
                return new string[0];
            }

            Product tempProduct = this.head;

            for (int i = 0; i < start; i++)
            {
                tempProduct = tempProduct.Next;
            }

            int length = Math.Min(end - start, this.Count);

            var products = new string[length];

            for (int i = 0; i < length; i++)
            {
                products[i] = tempProduct.Name;
                tempProduct = tempProduct.Next;
            }

            return products;*/
           
            string[] arr = new string[start + end];

            string[] products = ProvideInformationAboutAllProducts();

            for (int i = start; i < end && i < products.Length; i++)
            {
                arr[i] = products[i];
            }
            arr = arr.Where(c => c != null).ToArray();
            return arr;

        }

        public string RemoveProductByIndex(int index)
        {
            Product currentProduct = this.head;
            Product prevProduct = null;
            int currentIndex = 0;

            while (currentProduct != null)
            {
                if (currentIndex == index)
                {
                    if (prevProduct != null)
                    {
                        //prev.next = one cuur.next = two
                        prevProduct.Next = currentProduct.Next;
                    }
                    else
                    {
                        this.head = currentProduct.Next;
                    }

                    if (currentProduct.Next == null)
                    {
                        this.tail = prevProduct;
                    }
                    count--;
                    return currentProduct.Name;
                }
                else
                {
                    //prev = zero
                    prevProduct = currentProduct;
                    //curr = one
                    currentProduct = currentProduct.Next;
                    //currIndex = 1
                    currentIndex++;
                }
            }
            return null;
        }

        public string RemoveProductByName(string name)
        {
            Product product = this.head;
            int index = 0;
            string removedProd = null;
            while (product != null)
            {
                if (product.Name.Equals(name))
                {
                    removedProd = product.Name;
                    RemoveProductByIndex(index);
                }
                product = product.Next;
                index++;
            }

            return removedProd;
        }

        public bool CheckProductIsInStock(string name)
        {
            bool isInStock = false;
            Product product = this.head;
            int index = 0;
            while (product != null)
            {
                if (product.Name.Equals(name))
                {
                    isInStock = true;
                }

                product = product.Next;
                index++;
            }

            return isInStock;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            string[] arr = new string[this.Count];
            Product product = this.head;
            int index = 0;
            
            while(product != null)
            {
                arr[index] = product.Name;

                product = product.Next;
                index++;
            }

            return arr;
        }
                
    }
}
