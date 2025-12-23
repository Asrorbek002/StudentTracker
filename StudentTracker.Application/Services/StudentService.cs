using StudentTracker.Domain.Models;
using StudentTracker.Infrastructure.Data;

namespace StudentTracker.Application.Services;

public class StudentService
{
    public void Add(Student student)
    {
        DbContext.Students.Add(student);
    }

    public List<Student> GetAll()
    {
        return DbContext.Students;
    }
}
