using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Exseptions
{
    public class Login : Exception
    {
        public static string Email = "sadigfn.code.edu.az";
        public static string Password = "Sadiq1234";
        public Login(string message) : base(message)
        {

        }
        public static void Logins(string mail, string password)
        {
            try
            {
                if (mail != Email || password != Password)
                {
                    throw new Login("Gmail ve ya Password Sehvdir");
                }
                Console.WriteLine("Giris olundu");
            }
            catch (Exception message)
            {

                Console.WriteLine(message.Message); 
            }
        }

    }
}
