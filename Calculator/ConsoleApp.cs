namespace ConsoleApp1;

public class ConsoleApp : ParentApp
{
    public override void RunApp()
    {
        var left = ReadNumber("Enter the first number: ");
        var right = ReadNumber("Enter the second number: ");

        var calculator = new Calculator();

        Console.WriteLine("Sum: " + calculator.CalculateSum(left, right));
        Console.WriteLine("Diff: " + calculator.CalculateDiff(left, right));
        Console.WriteLine("Divide: " + calculator.CalculateDevide(left, right));
        Console.WriteLine("Multiplication: " + calculator.CalculateMultiply(left, right));
    }
}