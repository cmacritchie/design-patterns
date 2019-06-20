using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Beverage
    {

        public enum Size { Tall, Grande, Venti };

        Size size = Size.Tall;
        public string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public void setSize(Size size)
        {
            this.size = size;
        }
        public Size GetSize()
        {
            return this.size;
        }

        public abstract double cost();

    }
}
