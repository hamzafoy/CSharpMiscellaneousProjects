using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CSharpMiscellaneousProjects_PrintingQuotes
{
    
    public class QuotesHandler
    {
        public static class DatabaseRemote
        {
            public static SQLiteConnection conextion;
            public static SQLiteCommand cmd;
            public static SQLiteDataReader reader;

            public static void CreateDatabase()
            {
                if (!File.Exists("QuotesHandler.db3"))
                {
                    SQLiteConnection.CreateFile("QuotesHandler.db3");
                    string CreateTableQuery = @"CREATE TABLE Quote(
                                              ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                              Sentence VARCHAR(2000) NOT NULL,
                                              Author VARCHAR(100) NOT NULL
                                              )";
                    conextion = new SQLiteConnection("Data Source=QuotesHandler.db3;Version=3;");
                    conextion.Open();
                    cmd = new SQLiteCommand(CreateTableQuery, conextion);
                    cmd.ExecuteNonQuery();
                    conextion.Close();
                }
                else
                {
                    conextion = new SQLiteConnection("Data Source=QuotesHandler.db3;Version=3;");
                }

            }

            public static void InsertData(string quote, string source)
            {
                cmd = new SQLiteCommand();
                conextion.Open();
                cmd.Connection = conextion;
                cmd.CommandText = "INSERT INTO Quote(Sentence, Author) values (" + quote + "','" + source + "')";
                cmd.ExecuteNonQuery();
                conextion.Close();
            }

            public static void RetrieveAndReadData()
            {
                cmd = new SQLiteCommand("SELECT * FROM Quote", conextion);
                conextion.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("#" + reader[0] + "'" + reader[1] + "' - " + reader[2]);
                }
                conextion.Close();
            }

        }
        public static class Remote
        {
            private static char selection = 'X';
            public static char Selection
            {
                get { return selection; }
                set { selection = Char.ToUpper(value); }
            }

            public static void GetUserSelection()
            {
                var userinput = (char)Convert.ChangeType(Console.ReadLine(), typeof(char));
                ActOnSelection(userinput);
            }

            public static void ActOnSelection(char selection)
            {
                switch (selection)
                {
                    case 'A':
                        Console.WriteLine("Printing Quotes");
                        DatabaseRemote.RetrieveAndReadData();
                        break;
                    case 'B':
                        Console.WriteLine("Provide the quote without quotation marks, then the attributed's name");
                        DatabaseRemote.InsertData(Console.ReadLine(), Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Terminal Default");
                        break;
                }
            }

            public static void QuoteReader()
            {

            }

        }
    }
}
