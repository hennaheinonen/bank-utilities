using System;

namespace Bban
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Bban newAcount = new Bban("227720A35988");

            Console.WriteLine(newAcount.ToString());

            Bban account_2 = new Bban("123456-781");
            Console.WriteLine(account_2.ToString());

        }
    }
}
