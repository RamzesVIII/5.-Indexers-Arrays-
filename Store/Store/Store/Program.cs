using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Store mystore = new Store();
            Console.WriteLine(mystore[2].ToString());
            Console.WriteLine(new string (' ',20));
            Console.WriteLine(mystore["tv"]);
        }
    }
}
