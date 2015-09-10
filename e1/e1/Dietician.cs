using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    class Dietician : Employee
    {
        public override void Login()
        {
            //affects accessible stuff
            login = Console.ReadLine();
            passwd = Console.ReadLine();
        }

        public override void NewcomerRoutine()
        {
            //Doctor.NewcomerRoutine();
            //set up diet for the client based off of medical results
        }

        public override void DailyRoutine()
        {
            //daily check on client's condition
        }

        public override void WeeklyRoutine()
        {
            //weekly tweaks and improvements of the diet
        }
    }
}
