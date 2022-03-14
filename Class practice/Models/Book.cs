using System;
using System.Collections.Generic;
using System.Text;

namespace Class_practice.Models
{
    internal class Book : Product
    {
        public string genre;

        public Book(string genre, string name, int no, double price) : base(name, no, price)
        {
            this.genre = genre;
       
        }

        public void GetInfo()
        {
            Console.WriteLine($"Book: {name} - No: {no} - Price: {price} - Genre: {genre} Count: {count}");
        }
    }
}
