﻿using System;
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
        }
    }
}
