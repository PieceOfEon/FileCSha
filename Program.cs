string directory = @"D:\TestTG";
foreach (var fi in new DirectoryInfo(directory).EnumerateFiles("*.txt*", SearchOption.AllDirectories))
{
    string folderDate = "ForTXT";
    string newPath = directory + "\\" + folderDate;
 
    if (!Directory.Exists(newPath))
    {
        Directory.CreateDirectory(newPath);
        Console.WriteLine("Была создана папка: {0}", newPath);
    }

    newPath += "\\" + fi.Name;
    File.Move(fi.FullName, newPath);
    Console.WriteLine("Файл {0}, был перемещен в папку {1}", fi.FullName, newPath);
}
foreach (var fi in new DirectoryInfo(directory).EnumerateFiles("*.rtf*", SearchOption.AllDirectories))
{
    string folderDate2 = "ForRTF";
    string newPath2 = directory + "\\" + folderDate2;

    if (!Directory.Exists(newPath2))
    {
        Directory.CreateDirectory(newPath2);
        Console.WriteLine("Была создана папка: {0}", newPath2);
    }

    newPath2 += "\\" + fi.Name;
    File.Move(fi.FullName, newPath2);
    Console.WriteLine("Файл {0}, был перемещен в папку {1}", fi.FullName, newPath2);
}
foreach (var fi in new DirectoryInfo(directory).EnumerateFiles("*.bmp*", SearchOption.AllDirectories))
{
    string folderDate3 = "ForBMP";
    string newPath3 = directory + "\\" + folderDate3;

    if (!Directory.Exists(newPath3))
    {
        Directory.CreateDirectory(newPath3);
        Console.WriteLine("Была создана папка: {0}", newPath3);
    }

    newPath3 += "\\" + fi.Name;
    File.Move(fi.FullName, newPath3);
    Console.WriteLine("Файл {0}, был перемещен в папку {1}", fi.FullName, newPath3);
}

