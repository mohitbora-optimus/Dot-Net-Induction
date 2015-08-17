using System;

class TestEnum
{
    public enum WeekDays { Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

    static void Main(string[] args)
    {
        Console.WriteLine("enter day number");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("weekday is :" + (WeekDays)choice);
        Console.ReadKey();
    }
}
