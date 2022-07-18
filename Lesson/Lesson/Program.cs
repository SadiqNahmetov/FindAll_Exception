using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> number = new MyList<int>();

            number.Add(1);
            number.Add(2);
            number.Add(3);
            number.Add(4);
            number.Add(5);
            number.Add(6);
            number.Add(7);
            number.Add(8);
            number.Add(9);
            number.Add(10);
            number.Add(11);

            number.Clear();
            number.Add(11);
            number.Add(12);
            number.Add(13);
            number.Add(14);
            //number.GetAll();

            number.FindAll(m => m == 11);
            
          
          



        }
    }
}
