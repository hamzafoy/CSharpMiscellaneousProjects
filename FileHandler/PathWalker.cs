using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_FileHandler
{
    public class PathWalker
    {
        public static void Pathing()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var directoryName = Path.Join(desktop, "playFolder");
            Directory.CreateDirectory(directoryName);
            var fileName = Path.Join(directoryName, "text.txt");
            File.WriteAllText(fileName, "Can you read me?");
        }

        public static void Printer(string folderName, string file, string content)
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var directoryName = Path.Join(documents, folderName);
            Directory.CreateDirectory(directoryName);
            var fileName = Path.Join(directoryName, file);
            File.WriteAllText(fileName, content);
        }
    }
}
