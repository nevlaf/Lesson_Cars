using Lesson_Cars.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Model
{
    public class Car
    {
        public string name;
        public bool isDirty;
        public bool IsBreak;
        private double mileage;
        public int repair_number = 0;

        public double Mileage
        {
            get { return mileage; }
            set
            {
                if (value <= 0) throw new WastePathException();

                if (isDirty == false && IsBreak == false && value > 0)
                {
                    mileage += value;
                }
               
                if (mileage >= 1000 && repair_number < 1)
                {
                    IsBreak = true;
                    repair_number += 1;
                    mileage = 1000;
                    Console.WriteLine("Машина сломалась! (1000)");
                }
                else if (mileage >= 2000 && repair_number < 2)
                {
                    IsBreak = true;
                    repair_number += 1;
                    mileage = 2000;
                    Console.WriteLine("Машина сломалась! (2000)");
                }
                else if (mileage >= 5000 && repair_number < 3)
                {
                    IsBreak = true;
                    repair_number += 1;
                    mileage = 5000;
                    Console.WriteLine("Машина сломалась! (5000)");
                }
            }
        }

    }
}

