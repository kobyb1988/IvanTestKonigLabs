using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    class Admin : Employee
    {
        public override void Login()
        {
            //affects accessible stuff
            login = Console.ReadLine();
            passwd = Console.ReadLine();
        }

        public override void NewcomerRoutine()
        {
            //create a record for a new client / account for employee
        }

        public override void DailyRoutine()
        {
            //input new schedule if necessary
        }

        public override void WeeklyRoutine()
        {
            //input new diet if necessary
        }
    }
}
