// See https://aka.ms/new-console-template for more information


static string getOpenedAppFilepath()
{
    return System.Reflection.Assembly.GetEntryAssembly().Location;
}

Console.WriteLine("Hello, World!");
Console.WriteLine(getOpenedAppFilepath());
Console.WriteLine("Completed");
