using System;

namespace cw
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("#Student Class");
            Student s1 = new Student("Sevdzhan Alkan", "273217004", 4.2);
            s1.Show();

            Console.WriteLine("#International Student Class");
            InternationalStudent is1 = new InternationalStudent("Sevdzhan Alkan", "273217004", 4.2, "Turkey", "ITU");
            is1.Show();
            #endregion

            #region Task 2
            Console.WriteLine("#Rectangle");
            Rectangle r1 = new Rectangle(5, 8, "Red Rectangle");
            r1.PrintInfo();

            Console.WriteLine("#Square");
            Square sq1 = new Square(5, "Small Square");
            sq1.PrintInfo();
            #endregion

            #region Task 3
            Console.WriteLine("#Equipment");
            Equipment eq1 = new Equipment("Network Switch", "UK", 353.2);
            eq1.Display();

            Console.WriteLine("#Printer");
            Printer p1 = new Printer("Canon Printer", "Japan", 120.3584, 27);
            p1.Display();
            #endregion
        }
    }
}
