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
        public static double Repair(Car car)
        {
            if (car.Look == true) throw new DirtyException();
            switch (car.Mileage)
            {
                case 1000:
                    car.State = false;
                    return 120;
                case 2000:
                    car.State = false;
                    return 150;
                case 5000:
                    car.State = false;
                    return 180;
                default:
                    throw new MissingMileageException();                    
            }            
        }

    }
}
