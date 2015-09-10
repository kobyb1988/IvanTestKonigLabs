using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    abstract class Employee
    {
        //one obviously shouldn't store sensitive data as plaintext
        protected string login;
        protected string passwd;
        
        public abstract void Login();

        public abstract void NewcomerRoutine();

        public abstract void DailyRoutine();

        public abstract void WeeklyRoutine();
    }
}
