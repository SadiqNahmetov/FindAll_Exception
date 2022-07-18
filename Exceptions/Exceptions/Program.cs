using Exceptions.Exseptions;

using System;

namespace LoginException
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logins(Login.Email,  Login.Password);

        }


        static void Logins(string mail, string password)
        {
            try
            {
                if (mail != Login.Email || password != Login.Password)
                {
                    throw new Login("Mail ve ya Password sehvdir");
                }
                Console.WriteLine("Giris olundu");
            }
            catch (Exception message)
            {

                Console.WriteLine(message.Message); ;
            }
        }

    }
}
