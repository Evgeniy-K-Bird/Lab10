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
            first.Gradus = 13;
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
                if (value % 1 ==0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть целым");
                }
            }
            get
            {
                return gradus;
            }
            }

        public void ToRadians()
        {
            Console.WriteLine(result = gradus*(Math.PI/180) + min * (Math.PI / (180*60)) + sec * (Math.PI / (180*60*60)));
        }
    }
}
