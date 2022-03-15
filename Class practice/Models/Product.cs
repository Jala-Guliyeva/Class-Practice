using System;
using System.Collections.Generic;
using System.Text;

namespace Class_practice.Models
{
    internal class Product
    {
        public string name;
        public int no;
        public double price;
        public int count;

        public Product(string name, int no, double price)
        {
            this.name = name;
            this.no = no;
            this.price = price;
        }

        //public Product(string name,int no,double price, int count)
        //{
        //    this.name = name;
        //    this.no = no;
        //    this.price = price;
        //    this.count = count;
        //}
        
    }
}
