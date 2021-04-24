using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модель_больницы
{
    class Hospital
    {
        protected int number;
        protected string address;
        List<Doctor> doctors = new List<Doctor>();

        public Hospital(int number, string address)
        {
            this.number = number;
            this.address = address;
        }
        public int Number
        {
            get
            {
                return number;
            }
        }

        public void AddDoctor()
        {
            Console.WriteLine("Введите ФИО доктора");
            string fullName=Console.ReadLine();
            Console.WriteLine("Введите стаж доктора");
            int experience=Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Введите специализацию доктора");
            string specialization=Console.ReadLine();
            Doctor doc = new Doctor(number,address,fullName, experience, specialization);
            doctors.Add(doc);
        }
        public void PrintDoctor()
        {
            for(int i=0;i<doctors.Count;i++)
            {
                doctors[i].PrintDoctor();
            }
        }
    }
}
