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
        string name;
        bool isDirty;
        bool isBreak;
        double mileage;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }        

        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        public bool IsBreak
        {
            get { return isBreak; }
            set { isBreak = value; }
        }

        public double Mileage
        {
            get { return mileage; }
            private set { }
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
            if (isBreak == true) throw new BreakCarException();
            if (prediction >= 1000 && mileage >= 0 && mileage < 1000)
            {
                mileage = 1000;
                isBreak = true;
                isDirty = true;
            }
            else if (prediction >= 2000 && mileage >= 1000 && mileage < 2000)
            {
                mileage = 2000;
                isBreak = true;
                isDirty = true;
            }
            else if (prediction >= 5000 && mileage >= 2000 && mileage < 5000)
            {
                mileage = 5000;
                isBreak = true;
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

