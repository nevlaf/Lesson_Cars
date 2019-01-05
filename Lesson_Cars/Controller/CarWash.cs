using Lesson_Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_Cars.Exceptions;

namespace Lesson_Cars.Controller
{
    public static class CarWash
    {
        public static double Wash(Car car)
        {
            if (car.Look == false) throw new ClearCarException();
            car.Look = false;
            return 20;
        }
    }
}
