using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentBuilder
{
    public abstract class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich sandwich
        {
            get { return _sandwich; }
        }

        public abstract void AddBread();
        public abstract void AddProtein();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }
}
