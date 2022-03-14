using System;
using Class_practice.Models;

namespace Class_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int length = GetInputInt("Say?", 0);

            Book[] arr  = new Book[length];

            for (int i = 0; i < length; i++)
            {
                double price = GetInputDouble($"{i + 1}.ci kitabin qiymeti daxil edin: ", 10);

                int no = GetInputInt($"{i + 1}.ci kitabin nomresi: ", 1);
                string name = GetInputStr($"{i + 1}.ci kitabin adi: ", 2, 30);

                string genre = GetInputStr($"{i + 1}.ci kitabin janri: ", 2, 30);

                int count = GetInputInt($"{i + 1}.ci kitabin sayi: ", 2);

               

                arr[i] = new Book(genre, name, no, price)
                {
                    count = count
                  
                };
            }

            foreach (Book book in arr)
            {
                book.GetInfo();
            }


            //Console.WriteLine(" MENU ");
            ////Console.Clear();
            //Console.WriteLine("Secim edin:");
            //Console.WriteLine("1.Kitablari qiymete gore filtrle");
            //Console.WriteLine("2.Butun kitablari goster");
            //Console.WriteLine("3.Proqram baglansin");
            //Console.Write("\r\nSelect an option: ");

            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        Console.WriteLine(""); 
            //        break;
            //    case "2":
            //        ;
            //        break;
            //    case "3":
            //        break;
            //    default:
            //        break;
            //}
            int selection = 0;
            do
            {
                Console.WriteLine("1.Kitablari qiymete gore filtrle");
                Console.WriteLine("2.Butun kitablari goster");
                Console.WriteLine("0.Proqrami bagla");
                int say = GetInputInt("Say?", 0);
                Console.ReadLine();

                switch (selection)
                {
                    case 1:
                        

                        Console.WriteLine($"");
                        break;

                    case 2:
                        Console.WriteLine($"Butun melumatlari goster:");
                        

                        break;

                    case 3:
                    default:
                        Console.WriteLine("Proqram baglansin");
                        break;
                }


            } while (selection != 3);

        }
        static double GetInputDouble(string name, double min, double max = double.MaxValue)
        {
            double input;
            do
            {

                Console.WriteLine(name);
                input = Convert.ToDouble(Console.ReadLine());
            } while (input < min || input > max);

            return input;
        }
        static int GetInputInt(string name, int min, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);

            return input;
        }

      

        static string GetInputStr(string name, int min, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine(name);
                input = Console.ReadLine();
            } while (input.Length < min || input.Length > max);

            return input;

         

        }
          
    }
 }

