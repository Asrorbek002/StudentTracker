using StudentTracker.Domain.Models;

namespace StudentTracker.Infrastructure.Data;

public static class DbContext
{
    public static List<Student> Students { get; } = new();
    public static List<Attendance> Attendances { get; } = new();
}
