using System;

public class TimeManagementLibrary
{
    public TimeSpan CalculateWorkingHours(DateTime start, DateTime end)
    {
        if (end < start)
        {
            throw new ArgumentException("Khong hop le.");
        }

        return end - start;
    }

    public TimeSpan CalculateSleepHours(DateTime sleepStart, DateTime sleepEnd)
    {
        if (sleepEnd < sleepStart)
        {
            throw new ArgumentException("Khong hop le.");
        }

        return sleepEnd - sleepStart;
    }
}

class Program
{
    static void Main()
    {
        TimeManagementLibrary timeManagement = new TimeManagementLibrary();

        // Tính tổng số giờ ngủ từ 8:00 AM đến 17:00 PM
        DateTime workStart = new DateTime(2024, 1, 1, 8, 0, 0);
        DateTime workEnd = new DateTime(2024, 1, 1, 17, 0, 0);

        TimeSpan workingHours = timeManagement.CalculateWorkingHours(workStart, workEnd);
        Console.WriteLine($"Tong thoi gian lam viec: {workingHours.TotalHours} gio");

        // Tính tổng số giờ ngủ từ 11:00 PM đến 7:00 AM
        DateTime sleepStart = new DateTime(2024, 1, 1, 23, 0, 0);
        DateTime sleepEnd = new DateTime(2024, 1, 2, 7, 0, 0);

        TimeSpan sleepHours = timeManagement.CalculateSleepHours(sleepStart, sleepEnd);
        Console.WriteLine($"Tong thoi gian ngu: {sleepHours.TotalHours} gio");
    }
}
