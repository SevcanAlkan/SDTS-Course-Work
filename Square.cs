using System;

namespace cw
{
    public class Square : Rectangle
    {   
        public Square(double side, string name) : base(0, side, name)
        {
        }

        public override double Area(){
            return this.Width * this.Width;
        }        

        public override string ToString(){
            return $@"
            Name: {this.Name} 
            Side: {this.Width} 
            Area: {this.Area()} 
            ";
        }
    }
}