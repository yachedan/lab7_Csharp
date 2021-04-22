using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Metropolis metropolis = new(12,12,10,10000000,"Chernivtsi",10000,10);
            metropolis.Show();
            Console.WriteLine(metropolis.Density());
        }
    }
}
