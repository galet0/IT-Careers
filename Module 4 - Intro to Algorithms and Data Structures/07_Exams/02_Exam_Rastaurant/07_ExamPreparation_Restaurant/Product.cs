using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ExamPreparation_Restaurant
{
    class Product
    {
        private string name;
        private Product next;

        public Product(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Product Next
        {
            get { return this.next; }
            set
            {
                this.next = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product {0}", this.Name);
        }

    }
}
