// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using factorial;
using palindrome;
internal class Program
{
    private static void Main(string[] args)
    {
       Palin f = new Palin();
        f.get();
        Console.WriteLine(f.put());
    }
}
