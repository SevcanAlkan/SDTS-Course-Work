using System;

namespace cw
{
    public class Equipment{
        private string Name = "";
        private string CountryOfProducer = "";
        public double Price { private get; set; }

        public Equipment(string name, string countryOfProducer, double price)
        {
            this.Name = name;
            this.CountryOfProducer = countryOfProducer;
            this.Price = price;
        }

        public virtual void Display(){
            Console.WriteLine(this.ToString());
        }

        public override string ToString(){
            return $@"
            Name: {this.Name} 
            Country Of Producer: {this.CountryOfProducer}
            Price: {this.Price.ToString("0.00")}
            ";
        }
    }
}