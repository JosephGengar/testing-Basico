using System;

namespace Autorizacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static string Something()
        {
            return "Probando";
        }
        public static bool Login(string user, string password)
        {
            if (user == "jose" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
