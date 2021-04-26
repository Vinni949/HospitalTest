using System;
/*Модель больницы.
Врач в больнице характеризуется ФИО, специализацией и стажем работы.
Больница характеризуется номером и адресом.
Задача: создать программу, позволяющую выполнить следующие функции:

1) Выводит информацию обо всех врачах, находящихся в больнице (используя функцию вывода информации о враче)
2) Выводит информацию о больнице (адрес, номер, количество врачей в каждой специализации)
3) Осуществляет поиск врачей со стажем не менее N лет и заданной специализации.
4) Осуществляет поиск врача по ФИО и специализации
5) Осуществляет прием и увольнение врачей с работы.
*/


namespace Модель_больницы
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerHospital manager = new ManagerHospital();
            manager.AddHospital();
            manager.PrintHospital();
            manager.AddDoctor();
            manager.PrintDoctors();

            bool b = true;
            while(b==true)
            {
                manager.PrintHospital();
                Console.WriteLine("1 Добавление больницы.");
                Console.WriteLine("2 Добавление доктора.");
                Console.WriteLine("3 поиск врачей со стажем не менее N лет и заданной специализации.");
                Console.WriteLine("4 Осуществляет поиск врача по ФИО и специализации.");
                Console.WriteLine("5 Осуществляет прием и увольнение врачей с работы.");
                Console.WriteLine("6 Осуществляет увольнение врачей с работы.");
                Console.WriteLine("0 Выход.");
                int a = Convert.ToInt32(Console.ReadLine());
                switch(a)
                {
                    case 1:
                        manager.AddHospital();
                        break;
                    case 2:
                        manager.AddDoctor();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 0:
                        b=false;
                        break;
                        
                }
            }
        }
    }
}
