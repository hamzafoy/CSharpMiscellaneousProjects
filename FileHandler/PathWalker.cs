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
    }
}
