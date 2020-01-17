using System;

namespace cw
{
    public class Student : IStudent
    {
        private string _name;
        private string _facultiyNumber;
        private double _avarageGrade;

        public Student(string name, string facultiyNumber, double avarageGrade)
        {
            _name = name;
            _facultiyNumber = facultiyNumber;
            _avarageGrade = avarageGrade;
        }

        public double GetAvarageGrade()
        {
            return _avarageGrade;
        }

        public virtual void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $@"
            STUDENT INFORMATION: 
            -------------------- 
            Name: {_name} 
            * 
            Faculty Number: {_facultiyNumber} 
            * 
            Avarage Grade: {_avarageGrade} 
            -------------------- 
            ";
        }
    }

    public interface IStudent
    {
        double GetAvarageGrade();
        void Show();
    }
}
