using System;
using System.IO;
using System.Linq;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var newDirpath = Path.Combine("C:\\Users\\radum\\Documents", "Downloads");
            Directory.CreateDirectory(newDirpath);
            var oldDirpath = "C:\\Users\\radum\\Downloads";
            var files = Directory.GetFiles(oldDirpath);
            var groups = files.GroupBy(t => File.GetCreationTime(t).Date);
            foreach (var item in groups)
            {
                Console.WriteLine($"Group: {item.Key.Date.ToString().Split(" ")[0]}");
                var foldername = item.Key.Date.GetDateTimeFormats()[1];
                var dateDirPath = Path.Combine(newDirpath, foldername);
                Directory.CreateDirectory(dateDirPath);
                foreach (var i in item)
                {
                    var filename = i.Split("\\")[4];
                    var dstPath = Path.Combine(dateDirPath, filename);
                    Console.WriteLine(i);
                    File.Move(i, dstPath);
                }
                Console.WriteLine();
            }
            
        }
    }
}
