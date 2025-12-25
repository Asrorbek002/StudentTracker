namespace StudentTracker.Domain.Models;

public class ExternalAttendance : Attendance
{
    public string Source { get; set; } = string.Empty;
}
