using Lab_1.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person teacher1 = new Teacher("Михайлова Iрина Юрiївна", Gender.Female, new List<Subject>() { new Subject("Постреляційні бази даних")});
            Person teacher2 = new Teacher("Владiмiров Володимир Миколайович", Gender.Male, new List<Subject>() { new Subject("Вища математика")});
            Person teacher3 = new Teacher("Шаповалова Свiтлана Iгорiвна", Gender.Female, new List<Subject>() { new Subject("Штучний iнтелект"), new Subject("Декларативне програмування") });
            Person teacher4 = new Teacher("Карпенко Євген Юрiйович", Gender.Male, new List<Subject>() { new Subject("Веб-програмування"), new Subject("PHP") });
            try
            {
                teacher1.VisitSubject(new Subject("Постреляційні бази даних"));
            }
            catch(SubjectOutOfRozkladException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
