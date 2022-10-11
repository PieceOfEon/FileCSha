Random Rand = new Random();
string path = @"D:\GameTest5";
DirectoryInfo dirInfo = new DirectoryInfo(path);
string subpath = @"program";
if (!dirInfo.Exists)
{
    dirInfo.Create();
    Console.WriteLine("Успех");
}
else
{
    Console.WriteLine("Провал");
}
dirInfo.CreateSubdirectory(subpath);
for (int i = 0; i < 100; i++)
{
    int q;
    q = Rand.Next(0, 2);
    int a;
    a = Rand.Next(0,11);
    if(a==0)
    {
        break;
    }
    if(a<=9 && i>1)
    {
        if(q==1)
        {
            FileInfo f = new FileInfo(path+@"\"+subpath + @"\HELLO.txt");
            FileStream fs = f.Create();
        }
        subpath += @"\program";
        dirInfo.CreateSubdirectory(subpath);
    }
}
