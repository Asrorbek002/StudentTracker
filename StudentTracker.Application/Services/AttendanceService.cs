using StudentTracker.Domain.Models;
using StudentTracker.Infrastructure.Data;

namespace StudentTracker.Application.Services;

public class AttendanceService
{
    public void MarkAttendance(int studentId, bool isPresent)
    {
        DbContext.Attendances.Add(new Attendance
        {
            StudentId = studentId,
            Date = DateTime.Now,
            IsPresent = isPresent
        });
    }

    public List<Attendance> GetByStudentId(int studentId)
    {
        return DbContext.Attendances
            .Where(a => a.StudentId == studentId)
            .ToList();
    }
}
