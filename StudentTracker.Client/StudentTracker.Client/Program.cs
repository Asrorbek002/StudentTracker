using StudentTracker.Application.Services;
using StudentTracker.Domain.Models;

class Program
{
    static void Main()
    {
        var studentService = new StudentService();
        var attendanceService = new AttendanceService();

        studentService.Add(new Student { Id = 1, FullName = "Ali Saidov" });
        studentService.Add(new Student { Id = 2, FullName = "Isroil Qodirov " });
        studentService.Add(new Student { Id = 3, FullName = "Azamat Turdiyev " });

        attendanceService.Add(new Attendance { Id = 1, StudentId = 1, Date = DateTime.Today, IsPresent = true });
        attendanceService.Add(new Attendance { Id = 2, StudentId = 2, Date = DateTime.Today, IsPresent = false });
        attendanceService.Add(new Attendance { Id = 3, StudentId = 3, Date = DateTime.Today, IsPresent = true });

        Console.WriteLine("=== Students ===");
        foreach (var s in studentService.GetAll())
        {
            Console.WriteLine($"{s.Id} - {s.FullName}");
        }

        Console.WriteLine("\n=== Attendances ===");
        foreach (var a in attendanceService.GetAll())
        {
            Console.WriteLine($"StudentId: {a.StudentId}, Present: {a.IsPresent}");
        }
    }
}
