using System;

namespace SInjector
{
    public class DataAccessLayer :ICart
    {
        public string AddtoCart()
        {
            string val = "Nicolás ";
            string obj = "Automóvil";;
            Console.WriteLine(val);
            Console.WriteLine(obj);
            return string.Format(" {0} {1}" , val , obj);
        }

       
    }
}