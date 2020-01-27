using System;

namespace DesignPatterns.FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SandwichBuilder()
                        .WithCheedar()
                        .WithMayoMustard()
                        .WithMeat()
                        .Build();

            Console.WriteLine($"{builder.ToString()}");
            Console.ReadKey();
        }
    }
}
