using System;

namespace Function
{
    class Program
    {
        int a = 10;
        public void Test()
        {
            Console.WriteLine("this is test method");
        }

        public void Getdata(string a,string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);

        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Getdata("Pooja","Pune");

        }
    }
}
