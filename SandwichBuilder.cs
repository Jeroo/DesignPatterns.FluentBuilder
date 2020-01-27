using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentBuilder
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich sandwich
        {
            get { return _sandwich; }
        }

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

        public Sandwich Build()
        {
            return _sandwich;
        }
    }
}
