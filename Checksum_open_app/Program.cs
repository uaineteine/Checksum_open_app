// See https://aka.ms/new-console-template for more information


using Uaine.IO;
using Uaine.IO.Checksum;

static string getOpenedAppFilepath()
{
    return System.Reflection.Assembly.GetEntryAssembly().Location;
}

Console.WriteLine("Hello, World!");

string path = getOpenedAppFilepath();
Console.WriteLine(path);

FileData assFD = new FileData(path);
checksum md5sum  = assFD.CheckSum(ChecksumTypes.md5);
Console.WriteLine(md5sum.ChecksumString);

Console.WriteLine("Completed");
