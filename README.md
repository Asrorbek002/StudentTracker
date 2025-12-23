🏫 StudentTracker

StudentTracker — bu interaktiv C# konsol dasturi bo‘lib, foydalanuvchilarga talabalarni va ularning davomatini kuzatish imkonini beradi. Loyiha 4 qatlamli arxitektura asosida tuzilgan: Domain, Infrastructure, Application, Client.

📌 Arxitektura
StudentTracker
 ├─ StudentTracker.Domain        (Models)
 │    ├─ Student.cs
 │    ├─ Attendance.cs
 │    └─ ExternalAttendance.cs
 │
 ├─ StudentTracker.Infrastructure (Data storage)
 │    └─ DbContext.cs
 │
 ├─ StudentTracker.Application   (Services)
 │    ├─ StudentService.cs
 │    └─ AttendanceService.cs
 │
 └─ StudentTracker.Client        (Console App)
      └─ Program.cs


Domain – Loyihaning asosiy modellari (Student, Attendance, ExternalAttendance)

Infrastructure – Ma’lumotlar saqlanadigan qatlam (List ishlatilgan, array emas)

Application – Logika qatlamida Add va GetAll metodlari mavjud

Client – Konsol interfeysi orqali ishlash

🖥 Ishlash tartibi

Student qo‘shish:

var studentService = new StudentService();
studentService.Add(new Student { Id = 1, FullName = "Ali Karimov" });


Attendance qo‘shish:

var attendanceService = new AttendanceService();
attendanceService.Add(new Attendance { Id = 1, StudentId = 1, Date = DateTime.Today, IsPresent = true });


Barcha studentlarni ko‘rish:

foreach (var s in studentService.GetAll())
{
    Console.WriteLine($"{s.Id} - {s.FullName}");
}


Barcha attendance yozuvlarini ko‘rish:

foreach (var a in attendanceService.GetAll())
{
    Console.WriteLine($"StudentId: {a.StudentId}, Present: {a.IsPresent}");
}

🎬 Demonstratsiya (GIF)

GIFni qo‘yish uchun GitHub repoga .gif faylini qo‘shing va link-to-your-gif.gif o‘rniga real link qo‘ying.

📦 Foydalanish

Loyihani klonlash:

git clone https://github.com/username/StudentTracker.git


Visual Studio yoki VS Code da ochish

StudentTracker.Client ni startup project qilib ishga tushirish

Student qo‘shish, attendance yozish va ko‘rish imkoniyati mavjud

⚙ Texnologiyalar

C# 12 / .NET 8

Konsol dasturi

4 qatlamli arxitektura

List saqlash (Infrastructure)

👨‍💻 Muallif

Ali Karimov

GitHub: github.com/yourusername
