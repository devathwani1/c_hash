using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class xyz
    {
        string x;
        int a;
        int b;
        int c;
        public void get()
        {
            //ReadLine -> read whole line 
            //Read -> only read a single char
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }

        public void put()
        {
            c = a + b;
            Console.WriteLine(c.ToString());
        }
            
        class d
        {
            static void Main(string[] args)
            {
                xyz obj = new xyz();
                obj.get();
                obj.put();
            }
        }
    }
}
