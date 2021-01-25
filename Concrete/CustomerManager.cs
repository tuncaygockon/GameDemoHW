using GameDemoHW.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoHW.Concrete
{
    class CustomerManager
    {
        public void Delete(string customerPassword)
        {
            Console.WriteLine("Please enter your password again:");
        pass: string password = null;
            password = Console.ReadLine();
            if (password == customerPassword)
            {
                Console.WriteLine("Customer delete successful.");
            }
            else
            {
                Console.WriteLine("Wrong Password. Please try again.\r\n");
                goto pass;
            }

        }

        public void SignUp(Customer customer)
        {
            Console.WriteLine("Enter a new username: ");
            Console.ReadLine().ToString();
            Console.WriteLine("Enter a new password: ");
            Console.ReadLine().ToString();
            Console.WriteLine("You have succesfully signed up.Welcome. \r\n");
        }

        public void Update()
        {
            Console.WriteLine("Enter a new name: ");
            Console.ReadLine().ToString();
            Console.WriteLine("Enter a new last name: ");
            Console.ReadLine().ToString();
            Console.WriteLine("You have successfully updated your account.\r\n");
        }
    }
}
