using System;

namespace cw
{
    public class Rectangle
    {
        private double Length { get; set; }
        protected double Width { get; set; }
        protected string Name { get; set; }

        public Rectangle(double length, double width, string name){
            this.Length = length;
            this.Width = width;
            this.Name = name;
        }        

        public virtual double Area(){
            return this.Width * this.Length;
        }

        public virtual void PrintInfo(){
            Console.WriteLine(this.ToString());
        }

        public override string ToString(){
            return $@"
            Name: {this.Name} 
            Length: {this.Length} 
            Width: {this.Width} 
            Area: {this.Area()} 
            ";
        }
    }
}