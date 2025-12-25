# 🎓 StudentTracker Console App

StudentTracker — bu **C# Console Application** bo‘lib, **Clean Architecture**
asosida yozilgan. Ilova orqali studentlarni qo‘shish, o‘zgartirish,
qidirish va o‘chirish mumkin.

---

## 📸 Demo (GIF)

![Gif](https://github.com/user-attachments/assets/e35a6e31-9bf1-42c7-be32-40fbbdf932c2)




---

## 🏗 Arxitektura (Clean Architecture)

StudentTracker
│
├── StudentTracker.Domain
│ └── Models
│ └── Student.cs
│
├── StudentTracker.Infrastructure
│ └── Data
│ └── DbContext.cs
│
├── StudentTracker.Application
│ └── Services
│ └── StudentService.cs
│
└── StudentTracker.Client
└── Program.cs


### 🔹 Layerlar vazifasi:
- **Domain** → Entity / Model
- **Infrastructure** → Ma’lumot saqlash (List / DB)
- **Application** → Business logic
- **Client** → Console UI

---

## ✨ Mavjud funksiyalar

- ✅ Student qo‘shish
- ✏️ Student ma’lumotini o‘zgartirish
- 🔍 ID bo‘yicha qidirish
- 🔎 Name bo‘yicha qidirish
- 📋 Studentlar ro‘yxatini ko‘rish
- 🗑 Studentni ID bo‘yicha o‘chirish

---

## 🖥 Console Menu

=== STUDENT TRACKER ===

1. Student qo‘shish

2. Studentni o‘zgartirish

3. ID bo‘yicha qidirish

4. Name bo‘yicha qidirish

5. Studentlar ro‘yxati

6. ID bo‘yicha o‘chirish

0. Chiqish

---

## 🧩 Ishlatilgan texnologiyalar

- C#
- .NET Console App
- Clean Architecture
- OOP (Encapsulation, Separation of Concerns)

---

## 🚀 Ishga tushirish

1. Repozitoriyani clone qiling:
```bash
git clone https://github.com/USERNAME/StudentTracker.git
Visual Studio’da oching

StudentTracker.Client ni Startup Project qiling

Run (F5) bosib ishga tushiring

📌 Kelajakda qo‘shilishi mumkin
🔄 Auto Increment ID

📁 File / JSON saqlash

🗄 Database (SQL Server)

🔌 Dependency Injection

🧪 Unit Testlar

👨‍💻 Muallif
Asrorbek
Email: abdurashidovasrorbek@gmail.com
💻 C# / .NET Developer
