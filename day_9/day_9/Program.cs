using System;

namespace day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Test TestaObjekts = new Test();
            int rezultats = TestaObjekts.Saskaitisana(3, 7);

            Test TestaObjekts2 = new Test();

            TestaObjekts.skaitlis = 3;
            TestaObjekts2.skaitlis = 6;

            Console.WriteLine("izvade no TestaObjekts " + TestaObjekts.skaitlis);
            Console.WriteLine("izvade no TestaObjekts2 " + TestaObjekts2.skaitlis);

            Console.ReadLine();
        }
    }
}
