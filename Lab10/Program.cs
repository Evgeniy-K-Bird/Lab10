using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass first = new MyClass();
            first.Gradus = 23;
            first.ToRadians();
            Console.ReadKey();

        }
    }
    class MyClass
    {
        int gradus;
        int min;
        int sec;
        double result;
        public MyClass(int gradus = 0, int min = 0, int sec = 0)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public int Gradus
        {
            set
            {
                if (value > 0 && value < 361)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть от 0 до 360");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value > 0 && value < 61)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть от 0 до 60");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value > 0 && value < 61)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть от 0 до 60");
                }
            }
            get
            {
                return sec;
            }
        }
        public void ToRadians()
        {
            Console.WriteLine(gradus * (Math.PI / 180) + min * (Math.PI / (180 * 60)) + sec * (Math.PI / (180 * 60 * 60)));
        }
    }
}
