using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_Cars.Model;

namespace Lesson_Cars.View
{
    class View
    {
        public void SetMileage(Car car)
        {
            Console.WriteLine("Введите пройденный путь");
            car.Travel(Int32.Parse(Console.ReadLine()));
        }
        public void GetInfCar(Car car)
        {
            Console.WriteLine("Пробег = " + car.Mileage);
            Console.WriteLine("Требуется мойка = " + car.IsDirty);
            Console.WriteLine("Требуется ремонт = " + car.IsBreak);

        }
        public void Output(int x)
        {
            Console.WriteLine(x);
        }
    }
}
