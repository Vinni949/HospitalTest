using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модель_больницы
{
    class ManagerHospital
    {
        List<Hospital> list = new List<Hospital>();

        public void AddHospital()
        {
            Console.WriteLine("Введите номер больницы!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите адрес больницы!");
            string address= Console.ReadLine();
            Hospital hosp = new Hospital(number, address);
            list.Add(hosp);
            
        }
        public void AddDoctor()
        {
            Console.WriteLine("Ведите номер больницы к которой прикрепить доктора");
            int number= Convert.ToInt32(Console.ReadLine());
            Hospital found = list.Find(item => item.Number == number);
            found.AddDoctor();
        }
        public void PrintHospital()
        {
            foreach(Hospital hos in list)
            {
                Console.WriteLine(hos);
            }
        }
        public void PrintDoctors()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].PrintDoctor();
            }
        }
        public void RemoveDoctor()
        {
            Console.WriteLine("Ведите номер больницы к которой прикрепить доктора");
            int number = Convert.ToInt32(Console.ReadLine());
            Hospital found = list.Find(item => item.Number == number);
            found.RemoveDoctor();
        }

        public void SearchDoctor()
        {
            Console.WriteLine("ВВедите стаж доктора: ");
            int serchExperience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ВВедите специализацию доктора: ");
            string searchSpecialization = Console.ReadLine();
            for (int i = 0; i<list.Count;i++)
            {
                list[i].SearchDoctors(serchExperience, searchSpecialization);
            }
        }

    }
}
