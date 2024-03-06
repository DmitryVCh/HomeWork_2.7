using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Создание переменных и вывод
            string fullName = "Иванов Иван Иванович"; // Ф.И.О
            byte age = 23; // Возраст
            string email = "Ivan23@gmail.com"; // Email
            float notesProgramming = 4.5f; // Баллы по программированию
            float notesMath = 4.9f; // Баллы по математике
            float notesPhisics = 5f; // Баллы по физике

            Console.WriteLine($"\nФ.И.О.: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по программированию: {notesProgramming} \nБаллы по математике: {notesMath} \nБаллы по физике: {notesPhisics}");
            

            // Задание 2. Реализация подсчёта количества баллов по всем предметам

            float total = notesProgramming + notesMath + notesPhisics;
            float average = (notesProgramming + notesMath + notesPhisics) / 3;
            Console.WriteLine($"\nСумма баллов: {total} \nСреднее афиметическое баллов: {average}");
            Console.ReadKey();


        }
    }
}
