using StudentTracker.Domain.Models;
using StudentTracker.Infrastructure.Data;

namespace StudentTracker.Application.Services;

public class AttendanceService
{
    public void Add(Attendance attendance)
    {
        DbContext.Attendances.Add(attendance);
    }

    public List<Attendance> GetAll()
    {
        return DbContext.Attendances;
    }
}
