using System;

namespace DesignPatterns.FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandwich builder = SandwichBuilder
                                .CreateNew()                        
                                .WithCheedar()
                                .WithMayoMustard()
                                .WithMeat()                        
                                .Build();

            Console.WriteLine($"{builder.ToString()}");
            Console.ReadKey();
        }
    }
}
