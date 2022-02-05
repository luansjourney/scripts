using System.IO;


string tempDirPath = "C:/Windows/Temp";
DirectoryInfo usersTemp = new DirectoryInfo(Path.GetTempPath());
DirectoryInfo temp = new DirectoryInfo(tempDirPath);

foreach (FileInfo file in usersTemp.GetFiles())
{
    try
    {
        file.Delete();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

foreach (FileInfo file in temp.GetFiles())
{
    try
    {
        file.Delete();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


Console.ReadLine();