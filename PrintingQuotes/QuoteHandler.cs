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
                                              Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                              Sentence VARCHAR(2000) NOT NULL,
                                              Author VARCHAR(100) NOT NULL
                                              );
                                              CREATE TABLE Author(
                                              First_Name VARCHAR(50) NOT NULL,
                                              Last_Name VARCHAR(50),
                                              Quote_Id INTEGER,
                                              FOREIGN KEY(Quote_Id) REFERENCES Quote(Id)
                                              );";
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
                string[] FullName = source.Split(' ');

                string InsertQuery = @"INSERT INTO Quote(Sentence, Author) values ('" + quote + "','" + source + "'); INSERT INTO Author(First_Name, Last_Name) values ('" + FullName[0] + "','" + FullName[1] + "');";
                conextion.Open();
                cmd = new SQLiteCommand(InsertQuery, conextion);
                //cmd.Connection = conextion;
                //cmd.CommandText = "@INSERT INTO Quote(Sentence) values ('" + quote + "');";
                //cmd.CommandText = "INSERT INTO Author(First_Name, Last_Name) values ('" + FullName[0] + "','" + FullName[1] + "');";
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
                    Console.WriteLine("#" + reader[0] + " '" + reader[1] + "' - " + reader[2]);
                }
                conextion.Close();
            }

            public static void SearchDataByName(string searchterm)
            {
                cmd = new SQLiteCommand("SELECT * FROM Quote WHERE Author = '" + searchterm + "'", conextion);
                conextion.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine($"{searchterm} has the following quotes: ");
                while (reader.Read())
                {
                    Console.WriteLine("#" + reader[0] + " '" + reader[1] + "' - " + reader[2]);
                }
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
                        Console.WriteLine("\nPrinting Quotes\n");
                        DatabaseRemote.RetrieveAndReadData();
                        break;
                    case 'B':
                        Console.WriteLine("Provide the quote without quotation marks, then the attributed's name");
                        DatabaseRemote.InsertData(Console.ReadLine(), Console.ReadLine());
                        break;
                    case 'C':
                        Console.Write("Type the name of the quoted: ");
                        DatabaseRemote.SearchDataByName(Console.ReadLine());
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
