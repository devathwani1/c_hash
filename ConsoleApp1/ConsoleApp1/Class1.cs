using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Add
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
            
    }
}

namespace factorial
{
    internal class fact
    {
        int a;

        public void get()
        {
            a = Convert.ToInt32(Console.ReadLine());
        }

        public void put()
        {
            int result = 1;
            for (int i = a; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}

namespace multiply
{
    class Multi
    {
        int a, b;
        
        public void get()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }

        public int put()
        {
            return a * b;
        }
    }
}

namespace palindrome
{
    class Palin
    {
        string str;

        public void get()
        {
            str = Console.ReadLine();
        }

        public bool put()
        {
            int start = 0;
            int end = str.Length - 1;

            while (start < end)
            {
                if (str[start] != str[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}



namespace loading
{
    class Load
    {
        string stars = "*";
        public void start()
        {
            do   
            {
                stars += "*";
                Console.WriteLine('\r' + stars);
                Thread.Sleep(100);
                for (int i = 0; i < stars.Length; i++)
                {
                    Console.WriteLine("\b \b");
                }
            }
            while (true);
            
        }
    }
}

namespace switch_str
{
    class Switch
    {
        int a;
        public void get()
        {
            a = Convert.ToInt32(Console.ReadLine());
        }

        public void put()
        {
            switch (a)
            {
                case 0:
                    Console.WriteLine("This is the zero");
                    break;
                case 1:
                    Console.WriteLine("This is the one");
                    break;
                case 2:
                    Console.WriteLine("This is the two");
                    break;
                
            }
        }

    }
}
