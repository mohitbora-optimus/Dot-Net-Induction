using System;

class ReturningArray
{
    public string[] GetStringArray()
    {
        string[] Names = new string[] { "Tiwari", "Bhatti", "Jha", "rehan" };
        return Names;
    }


    public static void Main(String[] args)
    {
        ReturningArray p = new ReturningArray();
        foreach (string names in p.GetStringArray())
            Console.WriteLine(names);
        Console.ReadKey();
    }
}
        