using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модель_больницы
{
    class Doctor:Hospital //нет наследования
    {
        private string fullName;
        private int experience;
        private string specialization;
   
        public Doctor(int number, string address, string fullName, int experience, string specialization):base(number,address)
        {
            this.fullName = fullName;
            this.experience = experience;
            this.specialization = specialization;
        }

        public void PrintDoctor()
        {
            Console.Write(fullName + "   " + experience + "   " + specialization);
        }
    }
}
