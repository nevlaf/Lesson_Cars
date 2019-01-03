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
            car.Travel(1);
        }
    }
}
