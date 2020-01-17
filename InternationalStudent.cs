using System;

namespace cw
{
    public class InternationalStudent : Student, IStudent
    {
        private string _country;
        private string _ComesFrom;

        public InternationalStudent(string name, string facultiyNumber, double avarageGrade, string country, string comesFrom)
            : base(name, facultiyNumber, avarageGrade)
        {
            _country = country;
            _ComesFrom = comesFrom;
        }

        public override void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            string result = base.ToString();
            return result + $@"
            Country: {_country} 
            * 
            Comes From: {_ComesFrom} 
            ----------------- 
            ";
        }
    }
}
