using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1
{
    class Doctor : Employee
    {
        private void ECG()
        {
        }

        private void Sonography()
        {
        }

        private void BloodTest()
        {
        }

        private void StressTest()
        {
        }

        private void BodyMeasurements()
        {
        }

        public override void Login()
        {
            //affects accessible stuff
            login = Console.ReadLine();
            passwd = Console.ReadLine();
        }

        public override void NewcomerRoutine()
        {
            //initial measurements
            ECG();
            Sonography();
            BloodTest();
            StressTest();
            BodyMeasurements();
        }

        public override void DailyRoutine()
        {
            BodyMeasurements();
            StressTest();
        }

        public override void WeeklyRoutine()
        {
            ECG();
            Sonography();
            BloodTest();
        }
    }
}
