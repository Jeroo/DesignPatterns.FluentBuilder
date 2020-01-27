using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentBuilder
{
    public class SandwichBuilder
    {
        //Property Sandwich
        protected Sandwich _sandwich;

        // Initialize Object Sandwich
        public Sandwich sandwich
        {
            get { return _sandwich; }
        }


        // Methods builders
        public SandwichBuilder WithMeat() 
        {
            _sandwich.Protein = "Carne";
            return this;
        }
        public SandwichBuilder WithCheedar()
        {
            _sandwich.Cheese = "Queso Chedar";
            return this;
        }

        public SandwichBuilder WithMayoMustard()
        {
            _sandwich.Condiments = "Mayonesa, Mostaza";
            return this;
        }

        // Create Builder and return this entire builder
        public Sandwich Build()
        {
            return _sandwich;
        }
    }
}
