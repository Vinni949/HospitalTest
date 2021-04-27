using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модель_больницы
{
    class Hospital
    {
        private int number;
        private string address;
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
            int experience=Convert.ToInt32(Console.ReadLine());
            Doctor doc = new Doctor(number, address, fullName, experience);
            Console.WriteLine("Введите специализацию доктора");
            string specialization=Console.ReadLine();
            doc.Specialization(specialization);
            doctors.Add(doc);
        }
        public void PrintDoctor()
        {
            for(int i=0;i<doctors.Count;i++)
            {
                doctors[i].PrintDoctor();
            }
        }
        public override string ToString()
        {
            string s = number.ToString();
            return s;
        }
        public void RemoveDoctor()
        {
            string name = Console.ReadLine();
            for(int i=0;i<doctors.Count;i++)
            {
                if(doctors[i].GetDoc==name)
                {
                    doctors.RemoveAt(i);
                }
            }
        }
        public void SearchDoctors(int serchExperience, string searchSpecialization)
        {
            
            for(int i=0;i<doctors.Count;i++)
            {
                if(serchExperience <= doctors[i].getExperienceexperience && searchSpecialization==doctors[i].getSpec)
                {
                    doctors[i].PrintDoctor();
                }
            }

        }
        public void SearchDoctorsFullName(string fullName, string searchSpecialization)
        {

            for (int i = 0; i < doctors.Count; i++)
            {
                if (fullName == doctors[i].GetDoc && searchSpecialization == doctors[i].getSpec)
                {
                    doctors[i].PrintDoctor();
                }
            }

        }
    }
}
