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
        private bool isDirty;
        private bool isWork;
        private double mileage;
        private int Id;
        private static int count;
        
        public Car()
        {
            isDirty = false;
            isWork = true;
            Id = ++count;
            mileage = 0;
        }             

        public bool Look
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        public bool State
        {
            get { return isWork; }
            set { isWork = value; }
        }

        public double Mileage
        {
            get { return mileage; }
            private set { }
        }

        public double Count
        {
            get { return count; }
            private set { }
        }

        public override string ToString()
        {
            string working = isWork ? "работает" : "не работает";
            string look = isDirty ? "грязная" : "чистая";
            return string.Format("car id {0} ({1} {2}) summary count {3}", Id, working, look, count);
        }

        /// <summary>
        /// Метод прибавления пройденного пути машины
        /// </summary>
        /// <param name="path"></param>

        public void Travel(double path)
        {
            double prediction;
            prediction = mileage + path;
            if (path <= 0) throw new WastePathException();
            if (isWork == true) throw new BreakCarException();
            if (prediction >= 1000 && mileage >= 0 && mileage < 1000)
            {
                mileage = 1000;
                isWork = true;
                isDirty = true;
            }
            else if (prediction >= 2000 && mileage >= 1000 && mileage < 2000)
            {
                mileage = 2000;
                isWork = true;
                isDirty = true;
            }
            else if (prediction >= 5000 && mileage >= 2000 && mileage < 5000)
            {
                mileage = 5000;
                isWork = true;
                isDirty = true;

            }
            else
            {
                mileage += path;
                isDirty = true;
            }
        }   

    }
}

