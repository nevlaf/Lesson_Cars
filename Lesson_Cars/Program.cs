using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_Cars
{
    class Car
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
                if (isDirty == false && IsBreak == false && value > 0 )
                {
                    mileage += value;
                }
                
                if (value > 0)
                {
                    isDirty = true;
                    Console.WriteLine("Машина испачкалась!");
                    Console.WriteLine();
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
         
    class Program
    {
        static void Main(string[] args)
        {
            

            Car machine = new Car()
            {
                isDirty = false,
                IsBreak = false
            };

            Driver driver = new Driver();
            CarWash washer = new CarWash();
            RepairShop shop1 = new RepairShop();
            
            void InputDataDriver()
            {
                 Console.WriteLine("Добрый день! Введите имя водителя:");
                 driver.name = Console.ReadLine();
                 Console.WriteLine("Введите количество денег водителя:");
                 driver.account = Double.Parse(Console.ReadLine());
                 Console.WriteLine("Введите номер автомобиля");
                 machine.name = Console.ReadLine();
            }
            void OutputData()
            {                
                Console.WriteLine("Текущий пробег = " + machine.Mileage + " км");
                Console.WriteLine("Грязная = " + machine.isDirty);
                Console.WriteLine("Сломанная = " + machine.IsBreak);
                Console.WriteLine();
            }
                                             
            machine.name = "777";
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Введите пройденный путь автомобиля с номером № " + machine.name);
                machine.Mileage = Double.Parse(Console.ReadLine());                
                Console.WriteLine();
                Console.WriteLine("************************");
                Console.WriteLine();

                OutputData();

                Console.WriteLine();
                Console.WriteLine("************************");
                Console.WriteLine();

                if (machine.isDirty == true)
                {
                    washer.Wash(machine);
                    Console.WriteLine("Машина помыта!" + machine.isDirty);
                }
                if (machine.IsBreak == true)
                {
                    shop1.Repair(machine);
                    Console.WriteLine("Машина отремонтирована!" + machine.IsBreak);
                }

                Console.ReadKey();
                Console.Clear();
                
            }
            


        }
    }
}
