using StudentTracker.Domain.Models;

namespace StudentTracker.Infrastructure.Data;

public static class DbContext
{
    public static List<Student> Students { get; set; } = new();
    public static List<Attendance> Attendances { get; set; } = new();
}
