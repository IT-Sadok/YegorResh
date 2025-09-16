using ConsoleApp1;

Console.WriteLine("Choose your app: ");
Console.WriteLine("1. Digits: ");
Console.WriteLine("2. Random: ");

var appType = Console.ReadLine();
if (!int.TryParse(appType, out var choice))
{
    return;
}
ParentApp application;
if (choice == 1)
{
    application = new ConsoleApp();
}
else
{
   application = new RandomApp();
}
application.RunApp ();