using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    class Coach : Employee
    {
        public override void Login()
        {
            //affects accessible stuff
            login = Console.ReadLine();
            passwd = Console.ReadLine();
        }

        public override void NewcomerRoutine()
        {
            //waits for initial doctor's results then forms excersise course based on the given data
            //Doctor.NewcomerRoutine();
            //not sure how to represent flexibility of the excersise course
        }

        public override void DailyRoutine()
        {
            //adjust the amount of excersises to be done that/next day
        }

        public override void WeeklyRoutine()
        {
            //define general schedule for the whole week
        }
    }
}
