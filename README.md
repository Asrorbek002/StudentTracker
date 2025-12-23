# 🏫 StudentTracker

**StudentTracker** — interaktiv C# konsol dasturi bo‘lib, foydalanuvchilarga talabalarni va ularning davomatini kuzatish imkonini beradi. Loyiha **4 qatlamli arxitektura** asosida tuzilgan: Domain, Infrastructure, Application, Client.

---

## 📌 Arxitektura

StudentTracker
├─ StudentTracker.Domain (Models)
│ ├─ Student.cs
│ ├─ Attendance.cs
│ └─ ExternalAttendance.cs
│
├─ StudentTracker.Infrastructure (Data storage)
│ └─ DbContext.cs
│
├─ StudentTracker.Application (Services)
│ ├─ StudentService.cs
│ └─ AttendanceService.cs
│
└─ StudentTracker.Client (Console App)
└─ Program.cs


- **Domain** – Loyihaning asosiy modellari: `Student`, `Attendance`, `ExternalAttendance`  
- **Infrastructure** – Ma’lumotlar saqlanadi (`List` ishlatilgan, array emas)  
- **Application** – Logika: `Add` va `GetAll` metodlari mavjud  
- **Client** – Konsol interfeysi orqali ishlash  

---

## 🖥 Ishlash tartibi

### 1️⃣ Student qo‘shish

```csharp
var studentService = new StudentService();
studentService.Add(new Student { Id = 1, FullName = "Ali Karimov" });
studentService.Add(new Student { Id = 2, FullName = "Vali Aliyev" });
2️⃣ Attendance qo‘shish
csharp
var attendanceService = new AttendanceService();
attendanceService.Add(new Attendance { Id = 1, StudentId = 1, Date = DateTime.Today, IsPresent = true });
attendanceService.Add(new Attendance { Id = 2, StudentId = 2, Date = DateTime.Today, IsPresent = false });
3️⃣ Barcha studentlarni ko‘rish
csharp
foreach (var s in studentService.GetAll())
{
    Console.WriteLine($"{s.Id} - {s.FullName}");
}
4️⃣ Barcha attendance yozuvlarini ko‘rish
csharp
Copy code
foreach (var a in attendanceService.GetAll())
{
    Console.WriteLine($"StudentId: {a.StudentId}, Present: {a.IsPresent}");
}
```
# 🎬 Demonstratsiya (GIF)

GIF qo‘yish uchun .gif faylini GitHub repoga qo‘shing va linkni shu yerga joylashtiring.
---

# 📦 Foydalanish
Loyihani klonlash:

bash
Copy code
git clone https://github.com/yourusername/StudentTracker.git
Visual Studio yoki VS Code da ochish

StudentTracker.Client ni startup project qilib ishga tushirish

Student qo‘shish, attendance yozish va ko‘rish mumkin
---
## ⚙ Texnologiyalar
C# / .NET 9

Konsol dasturi

4 qatlamli arxitektura

List saqlash (Infrastructure)

## 👨‍💻 Muallif

GitHub:  [github.com/yourusername](https://github.com/Asrorbek002)
