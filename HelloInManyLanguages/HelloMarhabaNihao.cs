using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_HelloInManyLanguages
{
    public class HelloMarhabaNihao
    {
        public static string GreetMe()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What language do you speak?");
            Console.WriteLine("AR for Arabic, EN for English, SO for Somali");
            string language = Console.ReadLine();
            switch (language)
            {
                case "AR":
                    return $"Merhaban {name}, kayfa haluka?";
                case "EN":
                    return $"Hello {name}, how are you?";
                case "SO":
                    return $"Salam {name}, iska warran?";
                default:
                    return $"Dunno what language you speak mate!";
            }
        }
    }
}
