using Lesson_Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Controller
{
    class CarWash
    {
        public void Wash(Car car)
        {
            car.IsDirty = false;
        }
    }
}
