using System;

namespace cw
{
    public class StudentT4: Person {
        
        private string University {get;set;} 
        private string Specialty {get;set;}
        
        public StudentT4(int id, string name, string address, string university, string specialty) 
        : base(id, name, address)
        {
            this.University = university;
            this.Specialty = specialty;
        }

        public override string ToString(){
            return base.ToString() + $@"
            University: {this.University} 
            Specialty: {this.Specialty} 
            ";
        }
        
        public override void Show(){
            Console.WriteLine(this.ToString());
        }
    }
}