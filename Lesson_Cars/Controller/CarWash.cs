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
        public static void Wash(Car car)
        {
            if (car.IsDirty == false) throw new ClearCarException();
            car.IsDirty = false;
        }
    }
}
