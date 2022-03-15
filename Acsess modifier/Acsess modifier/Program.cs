using System;
using Acsess_modifier.Models;

namespace Acsess_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            User names = new User();
            //names.Age = 15;
            names.Password= 0;
            
            Console.WriteLine(names.Password);


        }   
} }
