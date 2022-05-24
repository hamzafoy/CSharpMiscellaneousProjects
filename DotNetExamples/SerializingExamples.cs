using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_DotNetExamples
{
    public class DummyCourse
    {
        public string Name { get; set; }
        public int Rating { get; set; }
    }
    public class SerializeToJSON
    {
        static DummyCourse course1 = new DummyCourse { Name = ".NET Big Picture", Rating = 5 };
        static DummyCourse course2 = new DummyCourse { Name = ".NET Asynchronous", Rating = 3 };
        static DummyCourse course3 = new DummyCourse { Name = ".NET HTTP Methods", Rating = 4 };
        static List<DummyCourse> courses = new List<DummyCourse>(new [] { course1, course2, course3 });


        static string textVersion = JsonSerializer.Serialize(courses);

        public static void readTextVersion()
        {
            Console.WriteLine(textVersion);
        }
    }


}
