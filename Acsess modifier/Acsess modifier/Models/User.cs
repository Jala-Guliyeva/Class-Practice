using System;
using System.Collections.Generic;
using System.Text;

namespace Acsess_modifier.Models
{
    class User
        
    {
        public User()
        {
            
        }
        public User(string userName, int age, int password)

        {
            this.Age = age;
            this.UserName = userName;
            this.Password = password;

        }

        public string UserName
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
        public int Age 
        {
            get
            {
                if (Age<0)
                {
                    Console.WriteLine("Age menfi ola bilmez");
                    return -1;
                }
                return Age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Age 18den  kicik ola bilmez");
                    return;
                }
                Age = value;
                Console.WriteLine("Okay giris olundu");
                
            }
        }


        public int Password {
            
            get
            {
                if (Password == 0 )
                {
                    Console.WriteLine("Bos ola bilmez");
                    return -1;

                }
                else
                {
                    
                }
               
                return Password;
            }
            set
            {
                if (value >8)
                {
                    Console.WriteLine("OKAY giris olundu");
                    return ;
                }
                else
                {
                    Console.WriteLine("olmadi");
                   
                }return;

               

            }
        }
       
       

               
               
            
        

    }
    
    
}
