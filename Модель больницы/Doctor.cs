using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модель_больницы
{
    class Doctor
    {
        private string fullName;
        private int experience;
        Specialization spec = new Specialization();

        public Doctor(int number, string address, string fullName, int experience)
        {
            this.fullName = fullName;
            this.experience = experience;
        }
        
        public void Specialization(string specialization)
        {
            spec.Spec = specialization;
        }

        public void PrintDoctor()
        {
            Console.WriteLine(fullName + "   " + experience + "   "+spec.Spec);
        }
        public string GetDoc
        {
            get
            {
                return fullName;
            }
        }
        public int getExperienceexperience
        {
            get
            {
                return experience;
            }
        }
        public string getSpec
        {
            get
            {
                return spec.Spec;
            }
        }
    }
}
