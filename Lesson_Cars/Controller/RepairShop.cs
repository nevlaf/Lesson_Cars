using Lesson_Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_Cars.Exceptions;

namespace Lesson_Cars.Controller
{
    public static class RepairShop
    {
        public static void Repair(Car car)
        {
            if (car.IsDirty == true) throw new DirtyException();
            car.IsBreak = false;
        }
    }
}
