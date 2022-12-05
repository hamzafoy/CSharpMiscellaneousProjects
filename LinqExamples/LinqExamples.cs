using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_LinqExamples
{
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
    class LinqFirstExample
    {
        private static string windowsPath = @"C:\users\hamza\Exercism\javascript\resistor-color";
        public static void ExecuteNonLinqMethods()
        {
            ShowLargeFilesWithoutLinq(windowsPath);
        }

        private static void ShowLargeFilesWithoutLinq(string windowsPath)
        {
            DirectoryInfo directory = new DirectoryInfo(windowsPath);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());
            foreach(FileInfo file in files)
            {
                Console.WriteLine($"{file.Name} ::->:: {file.Length}");
            }
        }
    }
}
