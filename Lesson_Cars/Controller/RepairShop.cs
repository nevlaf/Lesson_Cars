using Lesson_Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_Cars.Exceptions;

namespace Lesson_Cars.Controller
{
    class RepairShop
    {
        public void Repair(Car car)
        {
            if (car.IsDirty == true) throw new WastePathException();
            car.IsBreak = false;
        }
    }
}
