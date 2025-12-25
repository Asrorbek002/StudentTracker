using StudentTracker.Application.Services;
using StudentTracker.Domain.Models;

class Program
{
    static StudentService studentService = new();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================");
            Console.WriteLine("=== STUDENT TRACKER ===");
            Console.WriteLine("=======================");
            Console.ResetColor();
            Console.WriteLine("1. Student qo‘shish");
            Console.WriteLine("2. Studentni o‘zgartirish");
            Console.WriteLine("3. ID bo‘yicha qidirish");
            Console.WriteLine("4. Name bo‘yicha qidirish");
            Console.WriteLine("5. Studentlar ro‘yxati");
            Console.WriteLine("6. ID bo‘yicha o‘chirish");
            Console.WriteLine("0. Chiqish");
            Console.Write("Tanlang: ");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1": Add(); break;
                case "2": Update(); break;
                case "3": GetById(); break;
                case "4": GetByName(); break;
                case "5": GetAll(); break;
                case "6": Delete(); break;
                case "0": return;
                default: Console.WriteLine(" Noto‘g‘ri tanlov"); break;
            }

            Console.WriteLine("\nENTER bos...");
            Console.ReadLine();
        }
    }

    static void Add()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine()!);

        studentService.Add(new Student { Id = id, Name = name, Age = age });
        Console.WriteLine("Student qo‘shildi");
    }

    static void Update()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("New Name: ");
        string name = Console.ReadLine()!;

        Console.Write("New Age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.WriteLine(
            studentService.Update(new Student { Id = id, Name = name, Age = age })
            ? "Yangilandi"
            : "Topilmadi"
        );
    }

    static void GetById()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine()!);

        var s = studentService.GetById(id);
        Console.WriteLine(s == null ? "Yo‘q" : $"{s.Id} | {s.Name} | {s.Age}");
    }

    static void GetByName()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        foreach (var s in studentService.GetByName(name))
            Console.WriteLine($"{s.Id} | {s.Name} | {s.Age}");
    }

    static void GetAll()
    {
        foreach (var s in studentService.GetAll())
            Console.WriteLine($"{s.Id} | {s.Name} | {s.Age}");
    }

    static void Delete()
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.WriteLine(
            studentService.Delete(id)
            ?" O‘chirildi"
            : " Topilmadi"
        );
    }
}
