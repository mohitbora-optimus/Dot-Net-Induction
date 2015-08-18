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

        string[] a = p.GetStringArray();
        
        for( int i=0; i<a.Length; i++)
            Console.WriteLine(a[i]);
        Console.ReadKey();
    }
}
        