using System;

namespace cw 
{
    public class Printer : Equipment {
        public int PrintingSpeed { get; private set; }

        public Printer(string name, string countryOfProducer, double price, int printingSpeed) 
        : base (name, countryOfProducer, price)
        {
            this.PrintingSpeed = printingSpeed;
        }

        public override string ToString(){
            return base.ToString() + $@"
            Printing Speed: {this.PrintingSpeed} pages/minute
            ";
        }
    }
}