using StudentTracker.Domain.Models;
using StudentTracker.Infrastructure.Data;

namespace StudentTracker.Application.Services;

public class StudentService
{
    public void Add(Student student)
    {
        DbContext.Students.Add(student);
    }

    public bool Update(Student student)
    {
        var existing = GetById(student.Id);
        if (existing == null) return false;

        existing.Name = student.Name;
        existing.Age = student.Age;
        return true;
    }

    public Student? GetById(int id)
    {
        return DbContext.Students.FirstOrDefault(s => s.Id == id);
    }

    public List<Student> GetByName(string name)
    {
        return DbContext.Students
            .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Student> GetAll()
    {
        return DbContext.Students;
    }

    public bool Delete(int id)
    {
        var student = GetById(id);
        if (student == null) return false;

        DbContext.Students.Remove(student);
        return true;
    }
}
