namespace ConsoleApp1;

public class ParentApp
{
    public int ReadNumber(string text)
    {
        Console.WriteLine("Enter your number: ");
        return int.Parse(Console.ReadLine());
    }

    public virtual void RunApp()
    {
        Console.WriteLine("Base: ");
    }
}