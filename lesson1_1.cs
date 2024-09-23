// Запросить ввод с консоли: Имя, Фамилия, Отчество человека и как только будет введено последнее значение,
// вывести на экран всё в одну строчку
using System;
namespace lesson1;

class Program
{ 
    
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имя ");
        string? name = Console.ReadLine();

        Console.WriteLine("Введите отчество ");
        string? middlename = Console.ReadLine();

        Console.WriteLine("Введите фамилию ");
        string? surname = Console.ReadLine();

        Console.WriteLine($"{name} {middlename} {surname}");
        Console.ReadKey();
    }
}

