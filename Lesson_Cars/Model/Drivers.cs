using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Cars.Model
{
    public class Drivers
    {
        string name;
        int id;
        double wallet;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Wallet
        {
            get { return wallet; }
            set { wallet = value; }
        }

        public void Pay(double bill)
        {
            wallet -= bill;
        }

    }
}
