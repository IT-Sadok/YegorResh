using System.Text.Json;

namespace ConsoleApp1;

public class RandomApp : ParentApp
{
    public override void RunApp()
    {
        Console. WriteLine("Do you want to read from file? y/n");
        if (Console.ReadLine() == "y")
        {
            Console.WriteLine("File result: " + ValueFileManager.ReadValue());
        }
        else
        {
            var number = ReadNumber("Enter your number: ");
            var random = new Random();
            var generatedValue = random.Next(number);
        
            Console.WriteLine("Random: " + generatedValue);
        }
    }
}