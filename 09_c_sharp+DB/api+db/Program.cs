using api_db;
using System.Data.SQLite;
using System.Text;
using System.Text.Json;

namespace apiDb
{
    internal class Program
    {

        private static readonly HttpClient client = new HttpClient();
        private static string url = "https://api.openweathermap.org/data/2.5/forecast?lat=49.4508316&lon=32.0170455&appid=1f3392e20136e8f4d6c88fa9a9f33772";

        async static Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            SelectItemOfMenu();
            await getWeather();
            
            async Task getWeather()
            {
                Console.WriteLine("Database information has been updated!");
                var responseString = await client.GetStringAsync(url);
                var jsonAnswer = new Dictionary<string, string>()
                {
                    {"date_unix",""},
                    {"temp_kelvin",""},
                    {"feels_like_kelvin",""},
                    {"temp_min_kelvin",""},
                    {"temp_max_kelvin",""},
                    {"pressure_gpascal",""},
                    {"pressure_sea_level_gpascal",""},
                    {"pressure_grnd_level_gpascal",""},
                    {"humidity_percent",""},
                    {"weather_main",""},
                    {"weather_description",""},
                    {"wind_speed",""},
                    {"wind_deg",""},
                    {"wind_gust",""},
                    {"city_name",""},
                    {"city_coord_lat",""},
                    {"city_coord_lon",""},
                    {"country",""},
                    {"population",""},
                    {"timezone",""},
                    {"sunrise_unix",""},
                    {"sunset_unix",""},
                };
                
                WeatherForecast? weatherForecast =
                   JsonSerializer.Deserialize<WeatherForecast>(responseString);
                
                int counter = (int)weatherForecast?.cnt;

                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                CreateTable(sqlite_conn);

                while (counter > 0)
                {

                    // корень запроса
                    //Console.WriteLine($"cod: {weatherForecast?.cod}");
                    //Console.WriteLine($"mesage: {weatherForecast?.message}");
                    //Console.WriteLine($"cnt: {weatherForecast?.cnt}");

                    //========= блок List
                    //Console.WriteLine($"list count: {weatherForecast?.list?.Count}");

                    foreach (var weatherInfo in weatherForecast?.list)
                    {
                        // block DT
                        //Console.WriteLine($"dt: {weatherInfo?.dt}");
                        //date_unix = (long)weatherInfo?.dt;
                        jsonAnswer["date_unix"] = Convert.ToString(weatherInfo?.dt);

                        //===== block MAIN ( Class = WeatherInfoMain )
                        //Console.WriteLine($"weather temp: {weatherInfo?.main?.temp}");
                        jsonAnswer["temp_kelvin"] = Convert.ToString(weatherInfo?.main?.temp);

                        //Console.WriteLine($"weather feels_like: {weatherInfo?.main?.feels_like}");
                        jsonAnswer["feels_like_kelvin"] = Convert.ToString(weatherInfo?.main?.feels_like);

                        //Console.WriteLine($"weather temp_min: {weatherInfo?.main?.temp_min}");
                        jsonAnswer["temp_min_kelvin"] = Convert.ToString(weatherInfo?.main?.temp_min);

                        //Console.WriteLine($"weather temp_max: {weatherInfo?.main?.temp_max}");
                        jsonAnswer["temp_max_kelvin"] = Convert.ToString(weatherInfo?.main?.temp_max);

                        //Console.WriteLine($"weather pressure: {weatherInfo?.main?.pressure}");
                        jsonAnswer["pressure_gpascal"] = Convert.ToString(weatherInfo?.main?.pressure);

                        //Console.WriteLine($"weather sea_level: {weatherInfo?.main?.sea_level}");
                        jsonAnswer["pressure_sea_level_gpascal"] = Convert.ToString(weatherInfo?.main?.sea_level);

                        //Console.WriteLine($"weather grnd_level: {weatherInfo?.main?.grnd_level}");
                        jsonAnswer["pressure_grnd_level_gpascal"] = Convert.ToString(weatherInfo?.main?.grnd_level);

                        //Console.WriteLine($"weather humidity: {weatherInfo?.main?.humidity}");
                        jsonAnswer["humidity_percent"] = Convert.ToString(weatherInfo?.main?.humidity);

                        //======== block WIND ( Class = WeatherInfoWind.wind)
                        //Console.WriteLine($"weather wind speed : {weatherInfo?.wind?.speed}");
                        jsonAnswer["wind_speed"] = Convert.ToString(weatherInfo?.wind?.speed);

                        //Console.WriteLine($"weather wind deg : {weatherInfo?.wind?.deg}");
                        jsonAnswer["wind_deg"] = Convert.ToString(weatherInfo?.wind?.deg);

                        //Console.WriteLine($"weather wind gust : {weatherInfo?.wind?.gust}");
                        jsonAnswer["wind_gust"] = Convert.ToString(weatherInfo?.wind?.gust);

                        foreach (var WeatherInfoWeatherItem in weatherInfo?.weather)
                        {
                            //Console.WriteLine($"weather main: {WeatherInfoWeatherItem?.main}");
                            jsonAnswer["weather_main"] = Convert.ToString(WeatherInfoWeatherItem?.main);

                            //Console.WriteLine($"weather description: {WeatherInfoWeatherItem?.description}");
                            jsonAnswer["weather_description"] = Convert.ToString(WeatherInfoWeatherItem?.description);
                        }

                        //=============== блок City

                        //Console.WriteLine($"name: {weatherForecast?.city?.name}");
                        jsonAnswer["city_name"] = Convert.ToString(weatherForecast?.city?.name);

                        //Console.WriteLine($"lat: {weatherForecast?.city?.coord?.lat}");
                        jsonAnswer["city_coord_lat"] = Convert.ToString(weatherForecast?.city?.coord?.lat);

                        //Console.WriteLine($"lon: {weatherForecast?.city?.coord?.lon}");
                        jsonAnswer["city_coord_lon"] = Convert.ToString(weatherForecast?.city?.coord?.lon);

                        //Console.WriteLine($"country: {weatherForecast?.city?.country}");
                        jsonAnswer["country"] = Convert.ToString(weatherForecast?.city?.country);

                        //Console.WriteLine($"population: {weatherForecast?.city?.population}");
                        jsonAnswer["population"] = Convert.ToString(weatherForecast?.city?.population);

                        //Console.WriteLine($"timezone: {weatherForecast?.city?.timezone}");
                        jsonAnswer["timezone"] = Convert.ToString(weatherForecast?.city?.timezone);

                        //Console.WriteLine($"sunrise: {weatherForecast?.city?.sunrise}");
                        jsonAnswer["sunrise_unix"] = Convert.ToString(weatherForecast?.city?.sunrise);

                        //Console.WriteLine($"sunset: {weatherForecast?.city?.sunset}");
                        jsonAnswer["sunset_unix"] = Convert.ToString(weatherForecast?.city?.sunset);

                        // проверка заполнения start
                        //foreach (var pair in jsonAnswer)
                        //{
                        //    Console.WriteLine(pair.Key + "=" + pair.Value);
                        //}
                        //Console.WriteLine(counter);
                        // проверка заполнения finish


                        // insert to DB - start 
                        SQLiteCommand sqlite_cmd;
                        sqlite_cmd = sqlite_conn.CreateCommand();

                        sqlite_cmd.CommandText = $"INSERT INTO data (date_unix, temp_kelvin, feels_like_kelvin, temp_min_kelvin, temp_max_kelvin, pressure_gpascal, pressure_sea_level_gpascal, pressure_grnd_level_gpascal, humidity_percent, weather_main, weather_description, wind_speed, wind_deg, wind_gust, city_name, city_coord_lat, city_coord_lon, country, population, timezone, sunrise_unix, sunset_unix) " +
                                            $"VALUES('{jsonAnswer["date_unix"]}','{jsonAnswer["temp_kelvin"]}','{jsonAnswer["feels_like_kelvin"]}','{jsonAnswer["temp_min_kelvin"]}','{jsonAnswer["temp_max_kelvin"]}','{jsonAnswer["pressure_gpascal"]}','{jsonAnswer["pressure_sea_level_gpascal"]}','{jsonAnswer["pressure_grnd_level_gpascal"]}','{jsonAnswer["humidity_percent"]}','{jsonAnswer["weather_main"]}','{jsonAnswer["weather_description"]}','{jsonAnswer["wind_speed"]}','{jsonAnswer["wind_deg"]}','{jsonAnswer["wind_gust"]}','{jsonAnswer["city_name"]}','{jsonAnswer["city_coord_lat"]}','{jsonAnswer["city_coord_lon"]}','{jsonAnswer["country"]}','{jsonAnswer["population"]}','{jsonAnswer["timezone"]}','{jsonAnswer["sunrise_unix"]}','{jsonAnswer["sunset_unix"]}' ); ";
                        sqlite_cmd.ExecuteNonQuery();
                        // insert to DB - finish
                        

                    }

                    jsonAnswer.Clear();
                    counter--;
                }


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
        static System.Data.SQLite.SQLiteConnection ConnectAndSelect()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            return sqlite_conn;
        }
        static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS data(" +
                "id INTEGER PRIMARY KEY ON CONFLICT IGNORE AUTOINCREMENT, " +
                "date_unix NUMERIC UNIQUE ON CONFLICT REPLACE, " +
                "temp_kelvin TEXT(10), " +
                "feels_like_kelvin TEXT(10), " +
                "temp_min_kelvin TEXT(10), " +
                "temp_max_kelvin TEXT(10), " +
                "pressure_gpascal INTEGER, " +
                "pressure_sea_level_gpascal INTEGER, " +
                "pressure_grnd_level_gpascal INTEGER, " +
                "humidity_percent INTEGER, " +
                "weather_main TEXT(50), " +
                "weather_description TEXT(100), " +
                "wind_speed TEXT(5), " +
                "wind_deg TEXT(5), " +
                "wind_gust TEXT(5), " +
                "city_name TEXT(50), " +
                "[city_coord_lat] TEXT(10), " +
                "city_coord_lon TEXT(10), " +
                "country TEXT(50), " +
                "population INTEGER(10), " +
                "timezone NUMERIC(50), " +
                "sunrise_unix NUMERIC(50), " +
                "sunset_unix NUMERIC(50))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }
        static void InsertDataFromAPI(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            //sqlite_cmd.CommandText = $"INSERT INTO data (date_unix, temp_kelvin, feels_like_kelvin, temp_min_kelvin, temp_max_kelvin, pressure_gpascal, pressure_sea_level_gpascal, pressure_grnd_level_gpascal, humidity_percent, weather_main, weather_description, wind_speed, wind_deg, wind_gust, city_name, city_coord_lat, city_coord_lon, country, population, timezone, sunrise_unix, sunset_unix) " +
            //                         $"VALUES('{jsonAnswer[date_unix]}'); ";
            // date_unix, temp_kelvin, feels_like_kelvin, temp_min_kelvin, temp_max_kelvin, pressure_gpascal, pressure_sea_level_gpascal, pressure_grnd_level_gpascal, humidity_percent, weather_main, weather_description, wind_speed, wind_deg, wind_gust, city_name, city_coord_lat, city_coord_lon, country, population, timezone, sunrise_unix, sunset_unix
            sqlite_cmd = conn.CreateCommand();          
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
        static void SelectItemOfMenu()
        {
            while (true)
            {
                Console.WriteLine("Select query to DB");
                var menu = new Dictionary<int, string>()
            {
                {1, "Select the date and time with the earliest sunrise in Cherkasy."},
                {2, "Select the date when the latest sunset occurred in Cherkassy."},
                {3, "Calculate the number of days with rainy weather."},
                {4, "Find the day with the largest difference between the minimum and maximum temperature."},
                {5, "Select information for the current day."},
            };

                foreach (var pair in menu)
                {
                    Console.WriteLine($"{pair.Key} - {pair.Value}");
                }

                string[] numberQwery = Console.ReadLine().Trim().Split();
                int number = Convert.ToInt32(numberQwery[0]);
                SelectNumberQueryFromDB(number);
            }
            
        }

        static void SelectNumberQueryFromDB(int number)
        {
            switch (number)
            {
                case 1:
                    Console.Clear();
                    ReadData1(ConnectAndSelect());
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Clear();
                    ReadData2(ConnectAndSelect());
                    break;
                
                case 3:
                    Console.Clear();
                    ReadData3(ConnectAndSelect());
                    break;

                case 4:
                    Console.Clear();
                    ReadData4(ConnectAndSelect());
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Clear();
                    ReadData5(ConnectAndSelect());
                    Console.WriteLine();
                    break;
            }
        }

        static void ReadData1(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT date_unix, sunrise_unix FROM data ORDER BY sunrise_unix LIMIT 1;";
             //   "SELECT id, date_unix, sunrise_unix, sunset_unix FROM data";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=- Query #1 -=- Select the date and time with the earliest sunrise in Cherkasy.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Date\t\t\tTime with the earliest sunrise");
            
            while (sqlite_datareader.Read())
            {
                int date_unix = sqlite_datareader.GetInt32(0);
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(date_unix + 7200);
                DateTime dateItem = dateTimeOffset.DateTime;

                int sunrise_unix = sqlite_datareader.GetInt32(1);
                DateTimeOffset dateTimeOffset2 = DateTimeOffset.FromUnixTimeSeconds(sunrise_unix + 7200);
                DateTime localDateTime1 = dateTimeOffset2.DateTime;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{dateItem}\t{localDateTime1}");

            }
            Console.WriteLine();
        }
        static void ReadData2(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select date_unix, max(sunset_unix) from data;";
          
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=- Query #2 -=- Select the date when the latest sunset occurred in Cherkassy.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Date\t\t\tTime with the latest sunset.");

            while (sqlite_datareader.Read())
            {
                long date_unix = sqlite_datareader.GetInt32(0);
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(date_unix+7200);
                DateTime dateItem = dateTimeOffset.DateTime;

                int sunset_unix = sqlite_datareader.GetInt32(1);
                DateTimeOffset dateTimeOffset2 = DateTimeOffset.FromUnixTimeSeconds(sunset_unix+7200);
                DateTime localDateTime1 = dateTimeOffset2.DateTime;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{dateItem}\t{localDateTime1}");

            }
            Console.WriteLine();
        }
        static void ReadData3(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select count(weather_main) as 'count_days' from data where weather_main like \"Rain\";";
          
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=- Query #3 -=- Calculate the number of days with rainy weather.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The number of rainy days.");

            while (sqlite_datareader.Read())
            {
                int count_days = sqlite_datareader.GetInt32(0);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{count_days}");

            }
            Console.WriteLine();
        }
        static void ReadData4(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select date_unix, temp_min_kelvin, temp_max_kelvin from data;";
            //   "SELECT id, date_unix, sunrise_unix, sunset_unix FROM data";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=- Query #4 -=- Find the day with the largest difference between the minimum and maximum temperature..");

            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine($"Date\t\t\ttemp max, celsius\ttemp min, celsius\tdifference");

            DateTimeOffset dateTimeStart = DateTimeOffset.FromUnixTimeSeconds(7200);
            DateTime resultDateItem = dateTimeStart.DateTime;

            double max_temp = 0;
            double min_temp = 0;
            double differenceTemperature = double.MinValue;

            while (sqlite_datareader.Read())
            {
                int date_unix = sqlite_datareader.GetInt32(0);
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(date_unix + 7200);
                DateTime dateItem = dateTimeOffset.DateTime;

                double temp_min_kelvin = Convert.ToDouble(sqlite_datareader.GetString(1)) - 273.15;
                double temp_max_kelvin = Convert.ToDouble(sqlite_datareader.GetString(2)) - 273.15;

                double difference = Math.Abs(temp_max_kelvin - temp_min_kelvin);
                //Console.WriteLine($"{difference:f4}");
                if (difference > differenceTemperature)
                {
                    resultDateItem = dateItem;
                    max_temp = temp_max_kelvin;
                    min_temp = temp_min_kelvin;
                    differenceTemperature = difference;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine($"{resultDateItem}\t{max_temp:f2}\t\t\t{min_temp:f2}\t\t\t{differenceTemperature:f2}");

        }
        static void ReadData5(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            //sqlite_cmd.CommandText = "SELECT date_unix FROM data WHERE strftime('%s', 'now', 'start of day') - date_unix < 86400; ";
            sqlite_cmd.CommandText = "SELECT date_unix, temp_kelvin, feels_like_kelvin, weather_main, weather_description, wind_speed FROM data WHERE date_unix >= strftime('%s', 'now', 'start of day')+7200 AND date_unix < strftime('%s', 'now', 'start of day', '+1 day');";
            
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=- Query #5 -=- Select information for the current day.");

            Console.ForegroundColor = ConsoleColor.Blue;
           
            while (sqlite_datareader.Read())
            {
                int date_unix = sqlite_datareader.GetInt32(0);
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(date_unix+7200);
                DateTime dateItem = dateTimeOffset.DateTime;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"curent date\t\ttemp celsius\tfeels like celsius\tweather_main\tweather_description\twind_speed");

                double temp_kelvin = Convert.ToDouble(sqlite_datareader.GetString(1)) - 273.15;
                double feels_like_kelvin = Convert.ToDouble(sqlite_datareader.GetString(2)) - 273.15;
                string weather_main = sqlite_datareader.GetString(3);
                string weather_description = sqlite_datareader.GetString(4);
                string wind_speed = sqlite_datareader.GetString(5);

                Console.ForegroundColor = ConsoleColor.White;
                //{feels_like_kelvin} {weather_main} {weather_description} {wind_speed}
                Console.WriteLine($"{dateItem}\t{temp_kelvin:f2}\t\t{feels_like_kelvin:f2}\t\t\t{weather_main}\t\t{weather_description}\t\t{wind_speed}");
            }
        }

        static void ReadDataTest(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT id, date_unix, city_name, sunrise_unix, sunset_unix, feels_like_kelvin FROM data";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=-=-=--=-=    Query #1 ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"id\tdate_unix\t\tcity_name\tsunrise_unix\t\tsunset_unix\tfeels_like_kelvin");

            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);

                int date_unix = sqlite_datareader.GetInt32(1);
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(date_unix);
                DateTime dateItem = dateTimeOffset.DateTime;

                string city_name = sqlite_datareader.GetString(2);

                int sunrise_unix = sqlite_datareader.GetInt32(3);

                DateTimeOffset dateTimeOffset2 = DateTimeOffset.FromUnixTimeSeconds(sunrise_unix);
                DateTime localDateTime1 = dateTimeOffset2.DateTime;
                //DateTimeOffset dateTimeOffset2 = DateTimeOffset.FromUnixTimeSeconds(sunrise_unix);
                //DateTime sunrise = dateTimeOffset.DateTime;

                int sunset_unix = sqlite_datareader.GetInt32(4);

                string feels_like_kelvin = sqlite_datareader.GetString(5);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{id}\t{dateItem}\t{city_name}\t{localDateTime1}\t{sunset_unix}\t{feels_like_kelvin}");

            }
            Console.WriteLine();

        }
    }
}
