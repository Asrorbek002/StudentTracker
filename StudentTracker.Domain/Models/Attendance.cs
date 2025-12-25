namespace StudentTracker.Domain.Models;

public class Attendance
{
    public int StudentId { get; set; }
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
}
