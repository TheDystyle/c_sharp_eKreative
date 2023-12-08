using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace api_db_framework
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static string url1 = "https://api.openweathermap.org/data/2.5/forecast?lat=49.4508316&lon=32.0170455&appid=1f3392e20136e8f4d6c88fa9a9f33772&cnt=1";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            async Task getWeather(string url)
            {
                var responseString = await client.GetStringAsync(url);
                Console.WriteLine(responseString);
            }

            Console.WriteLine("History");
            await getWeather(url1);
            // -=-=-=-=-=-=-=-=-=-=-=-=- блок подключения БД
            // создать таблицу
            //вписать данные
            //Console.WriteLine("Hello World!");
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            //InsertData(sqlite_conn);
            //ReadData(sqlite_conn);
            //Console.WriteLine("End!");
            // -=-=-=-=-=-=-=-=-=-=-=-=- 








            var startPosition = new List<string>()
            { "\t\tЧто нужно сделать?",
              "-> получить погоду онлайн\t",
              "   посмотреть архив",
              "   получить погоду онлайн\t",
              "-> посмотреть архив"
            };
            //StartFunction(startPosition);
        }
        static void StartFunction(List<string> startPosition)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(startPosition[0]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(startPosition[1]);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(startPosition[2]);

            bool flag = true;
            while (flag)
            {
                //int SelectApiOrDb = 
                PushKey(startPosition);
                //if(SelectApiOrDb == 1)
                //    {
                //        Console.Write("Онлайн");
                //    }
                //else if (SelectApiOrDb == 2)
                //    {
                //        Console.Write("архив в БД");
                //    }
                //else {
                //        Console.Write("выход");
                //        flag = false;
                //    }

            }
        }

        static void PushKey(List<string> startPosition)
        {
            ConsoleKeyInfo charKey = Console.ReadKey();
            //Console.Beep(440, 100);
            switch (charKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(startPosition[0]);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(startPosition[1]);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(startPosition[2]);

                    ConsoleKeyInfo charKey2 = Console.ReadKey();
                    //return 1;
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(startPosition[0]);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(startPosition[3]);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(startPosition[4]);

                    Console.ForegroundColor = ConsoleColor.White;

                    break;

                case ConsoleKey.Enter:
                    break;
                    //default:
                    //    return 3;

            }
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=weather.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS data(" +
                "id INTEGER PRIMARY KEY ON CONFLICT IGNORE AUTOINCREMENT, " +
                "date_unix NUMERIC UNIQUE ON CONFLICT IGNORE, " +
                "temp_kelvin REAL(10), " +
                "feels_like_kelvin REAL(10), " +
                "temp_min_kelvin REAL(10), " +
                "temp_max_kelvin REAL(10), " +
                "pressure_gpascal INTEGER, " +
                "pressure_sea_level_gpascal INTEGER, " +
                "pressure_grnd_level_gpascal INTEGER, " +
                "humidity_percent INTEGER, " +
                "weather_main TEXT(50), " +
                "weather_description TEXT(100), " +
                "wind_speed REAL(5), " +
                "wind_deg REAL(5), " +
                "wind_gust REAL(5), " +
                "city_name TEXT(50), " +
                "[city_coord_lat] REAL(10), " +
                "city_coord_lon REAL(10), " +
                "country TEXT(50), " +
                "population INTEGER(10), " +
                "timezone NUMERIC(50), " +
                "sunrise_unix NUMERIC(50), " +
                "sunset_unix NUMERIC(50))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test1 Text1 ', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test2 Text2 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable1 (Col1, Col2) VALUES('Test3 Text3 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }
    }
}
