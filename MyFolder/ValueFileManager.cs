using System.Text.Json;

namespace ConsoleApp1;

public class ValueFileManager
{
    private static string _filePath = "value.json";
    
    public static void WriteValue(int value)
    {
        var randomGeneratorValue = new RandomGeneratorValue
        {
            Value = value,
            DateCreated =  DateTime.UtcNow
        };
        
        var json = JsonSerializer.Serialize(randomGeneratorValue);
        File.WriteAllText("value.json", json);
    }
    public static int ReadValue()
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine("File does not exist, try another time");
            return 0;
        }
        
        var value = JsonSerializer.Deserialize<RandomGeneratorValue>(File.ReadAllText(_filePath));
        
        return value.Value;
    }
}