using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz02_last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            StartFunction();
        }
        static void StartFunction()
        {
            if (CreateOrDefault() == 1)
            {
                int itemList = Convert.ToInt32(ListTable());
                if (itemList == 1)
                {
                    bool flag = true;
                    while (flag)
                    {
                        HandleInsertDataToCars();

                        Console.WriteLine("Do you want to add 1 item?\n1 - Yes, 2 - No");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        if (answer != 1)
                        {
                            ReadAnswerSql(ChooseQuery());

                        }
                    }

                }

                if (itemList == 2)
                {
                    bool flag = true;
                    while (flag)
                    {
                        HandleInsertDataToClients();

                        Console.WriteLine("Do you want to add item?\n1 - Yes, 2 - No");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        if (answer != 1)
                        {
                            ReadAnswerSql(ChooseQuery());

                        }
                    }

                }



            }
            else
            {
                DefaultDB();
            }
        }
        static int CreateOrDefault()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Do you want edit DB or use the default DB?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("->Edit     Default");

            int select = 1;
            while (true)
            {
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    // крокуємо
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Do you want edit DB or use the default DB?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("->Edit     Default");
                        select = 1;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Do you want edit DB or use the default DB?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("  Edit   ->Default");
                        select = 2;
                        break;
                    case ConsoleKey.Enter:
                        return select;
                        //break;

                }
            };

        }
        static void DefaultDB()
        {
            Console.Clear();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            Console.WriteLine("DB downloaded");

            Console.ForegroundColor = ConsoleColor.Blue;
            ReadAnswerSql(ChooseQuery());

        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=auto.db; Version = 3; New = True; Compress = True; ");
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
            string Createsql = "CREATE TABLE IF NOT EXISTS cars (id INTEGER PRIMARY KEY ON CONFLICT IGNORE AUTOINCREMENT, manufacturer TEXT NOT NULL, model TEXT, year_production INTEGER, id_clients INTEGER REFERENCES clients (id) ON UPDATE SET NULL)";
            string Createsql1 = "CREATE TABLE IF NOT EXISTS clients (id INTEGER PRIMARY KEY ON CONFLICT IGNORE AUTOINCREMENT, name TEXT NOT NULL, year_birth INTEGER NOT NULL, phone INTEGER NOT NULL)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
        }
        static string ListTable()
        {
            Console.WriteLine("Select table:");
            var tables = new List<string>()
            {
                "1 - Cars",
                "2 - Clients"
            };
            Console.WriteLine($"{tables[0]}\n{tables[1]}");
            return Console.ReadLine();

        }
        static void HandleInsertDataToCars()
        {
            Console.WriteLine("Input manufacturer");
            string manufacturer = Console.ReadLine();

            Console.WriteLine("Input model");
            string model = Console.ReadLine();


            Console.WriteLine("Input year_production");
            int year_production = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Input id_clients");
            int id_clients = Convert.ToInt32(Console.ReadLine());

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            SQLiteConnection conn = new SQLiteConnection(sqlite_conn);
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO cars(manufacturer, model, year_production, id_clients) VALUES('{manufacturer}', '{model}', {year_production}, {id_clients}); ";
            sqlite_cmd.ExecuteNonQuery();

            ReadLastItemFromCars(sqlite_conn);
        }
        static void HandleInsertDataToClients()
        {
            Console.WriteLine("Input name");
            string name = Console.ReadLine();

            Console.WriteLine("Input year_bearth");
            int year_birth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input phone");
            int id_clients = Convert.ToInt32(Console.ReadLine());

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            SQLiteConnection conn = new SQLiteConnection(sqlite_conn);
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO clients(name, year_birth, phone) VALUES('{name}', {year_birth}, {id_clients}); ";
            sqlite_cmd.ExecuteNonQuery();

            ReadLastItemFromClients(sqlite_conn);
        }
        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            // insert to table CARS
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(1, 'Porche', 'Targa', 2015, 6); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(2, 'Ford', 'Kuga', 2019, 8); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(3, 'Fiat', 'Doblo', 2003, 9); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(4, 'Ford', 'Mustang', 2010, 8); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(5, 'Peugeot', 'Partner', 2020, 7); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(6, 'Porche', 'Panamera', 2023, 6); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(7, 'Chery', 'QQ', 2005, 5); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(8, 'Scoda', 'Fabia', 2015, 4); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(9, 'Totota', 'Camry', 2020, 3); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(10, 'VAZ', '2101', 1986, 10); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(11, 'VAZ', '2109', 2006, 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(12, 'Audi', 'TT', 2000, 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO cars(id, manufacturer, model, year_production, id_clients) VALUES(13, 'Nissan', 'X-trail', 2010, 10); ";
            sqlite_cmd.ExecuteNonQuery();

            // insert to table CLIENTS
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(1, 'Ann', 1987, 12345); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(2, 'Striker', 1985, 4324987); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(3, 'Jax', 1983, 4923684); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(4, 'Alex', 1980, 98674); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(5, 'Magda', 2003, 3964821); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(6, 'Mary', 2001, 938475); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(7, 'Max', 1999, 987532); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(8, 'Tom', 2000, 777777); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(9, 'Denis', 1990, 456783); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(10, 'Bob', 1986, 123111); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO clients(id, name, year_birth, phone) VALUES(11, 'Cyrby', 1995, 8888888); ";
            sqlite_cmd.ExecuteNonQuery();
            conn.Close();
        }
        static System.Data.SQLite.SQLiteConnection ConnectAndSelect()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            return sqlite_conn;
        }
        static int ChooseQuery()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Select and enter the SQL query number\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" +
                " 1.Select all customers with the letter \"B\" in their name\n" +
                " 2.Select all clients born between 2000 and 2010\n" +
                " 3.Select all cars made by Audi\n" +
                " 4.Select all cars of the customer with id = 1\n" +
                " 5.Select all cars whose owners were born before 2000\n" +
                " 6.Select the name of the oldest customer\n" +
                " 7.Show the number of cars for the customer with id = 1\n" +
                " 8.Print the data about the customer with the newest car");

            Console.ForegroundColor = ConsoleColor.White;
            int select = Convert.ToInt32(Console.ReadLine());
            return select;

        }
        static void ReadAnswerSql(int select)
        {
            switch (select)
            {
                case 1:
                    Console.Clear();
                    ReadData1(ConnectAndSelect());

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
                    break;
                case 5:
                    Console.Clear();
                    ReadData5(ConnectAndSelect());
                    break;
                case 6:
                    Console.Clear();
                    ReadData6(ConnectAndSelect());
                    break;
                case 7:
                    Console.Clear();
                    ReadData7(ConnectAndSelect());
                    break;
                case 8:
                    Console.Clear();
                    ReadData8(ConnectAndSelect());
                    break;

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Do you want to select query?\n1 - Yes, 2 - No");
            int moreQuary = Convert.ToInt32(Console.ReadLine());
            if (moreQuary == 1)
            {
                Console.Clear();
                ReadAnswerSql(ChooseQuery());
            }
            else
            {
                StartFunction();
            }

        }
        static void ReadLastItemFromCars(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM cars ORDER BY id DESC LIMIT 1";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=-=-=--=-=    Last position ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"id\tmanufactured\tmodel\t\tyear_production\tid_clients");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string manufactured = sqlite_datareader.GetString(1);
                string model = sqlite_datareader.GetString(2);
                int year_production = sqlite_datareader.GetInt32(3);
                int id_clients = sqlite_datareader.GetInt32(4);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{id}\t{manufactured}\t\t{model}\t\t{year_production}\t\t{id_clients}");
            }
            Console.WriteLine();
        }static void ReadLastItemFromClients(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM clients ORDER BY id DESC LIMIT 1";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=-=-=--=-=    Last position ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"id\t\tname\t\tyear_birth\tphone");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                int year_birth = sqlite_datareader.GetInt32(2);
                int phone = sqlite_datareader.GetInt32(3);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{id}\t\t{name}\t\t{year_birth}\t\t{phone}");
            }
            Console.WriteLine();
        }
        static void ReadData0(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM cars";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"-=-=-=--=-=    Query #0 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"id\tmanufactured\tmodel\t\tyear_production\tid_clients");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string manufactured = sqlite_datareader.GetString(1);
                string model = sqlite_datareader.GetString(2);
                int year_production = sqlite_datareader.GetInt32(3);
                int id_clients = sqlite_datareader.GetInt32(4);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{id}\t{manufactured}\t\t{model}\t\t{year_production}\t\t{id_clients}");
            }
            Console.WriteLine();

        }
        static void ReadData1(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "Select * from clients where name like '%B%'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"-=-=-=--=-=    Query #1 \n" +
                $"Select all customers with the letter \"B\" in their name\n" +
                $"id\tname\t\tyear_birth\tphone\t");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                int year_birth = sqlite_datareader.GetInt32(2);
                int phone = sqlite_datareader.GetInt32(3);

                Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine($"id: {id} manufactured: {manufactured}\tmodel: {model} \tyear_production: {year_production} \tid_clients: {id_clients}");
                Console.WriteLine($"{id}\t{name}\t\t{year_birth}\t\t{phone}");
            }
            Console.WriteLine();
        }
        static void ReadData2(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "Select * from clients where year_birth > 2000 and year_birth <2010";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"-=-=-=--=-=    Query #2 \nid\tname\t\tyear_birth\tphone\t");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                int year_birth = sqlite_datareader.GetInt32(2);
                int phone = sqlite_datareader.GetInt32(3);


                //Console.WriteLine($"id: {id} manufactured: {manufactured}\tmodel: {model} \tyear_production: {year_production} \tid_clients: {id_clients}");
                Console.WriteLine($"{id}\t{name}\t\t{year_birth}\t\t{phone}");
            }
            Console.WriteLine();
        }
        static void ReadData3(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "Select * from clients where year_birth >= 2000 and year_birth <=2010";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"-=-=-=--=-=    Query #3 \nid\tname\t\tyear_birth\tphone\t");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                int year_birth = sqlite_datareader.GetInt32(2);
                int phone = sqlite_datareader.GetInt32(3);


                //Console.WriteLine($"id: {id} manufactured: {manufactured}\tmodel: {model} \tyear_production: {year_production} \tid_clients: {id_clients}");
                Console.WriteLine($"{id}\t{name}\t\t{year_birth}\t\t{phone}");
            }
            Console.WriteLine();
        }
        static void ReadData4(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            sqlite_cmd.CommandText = "Select * " +
                "from cars " +
                "where manufacturer = 'Audi'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.WriteLine($"-=-=-=--=-=    Query #4 \nid\tmanufacturer\t\tmodel\tyear_production\tid_clients");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string manufacturer = sqlite_datareader.GetString(1);
                string model = sqlite_datareader.GetString(2);
                int year_production = sqlite_datareader.GetInt32(3);
                int id_clients = sqlite_datareader.GetInt32(4);


                //Console.WriteLine($"id: {id} manufactured: {manufactured}\tmodel: {model} \tyear_production: {year_production} \tid_clients: {id_clients}");
                Console.WriteLine($"{id}\t{manufacturer}\t\t{year_production}\t\t{id_clients}");
            }
            Console.WriteLine();
        }
        static void ReadData5(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "Select manufacturer, model from cars where id_clients = 1";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"-=-=-=--=-=    Query #5 \nmanufacturer\t\tmodel");
            while (sqlite_datareader.Read())
            {
                string manufacturer = sqlite_datareader.GetString(0);
                string model = sqlite_datareader.GetString(1);

                //Console.WriteLine($"id: {id} manufactured: {manufactured}\tmodel: {model} \tyear_production: {year_production} \tid_clients: {id_clients}");
                Console.WriteLine($"{manufacturer}\t\t{model}");
            }
            Console.WriteLine();
        }
        static void ReadData6(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "Select manufacturer, model from cars where id_clients in (select id from clients where year_birth < 2000)";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"-=-=-=--=-=    Query #6 \nmanufacturer\t\tmodel");
            while (sqlite_datareader.Read())
            {
                string manufacturer = sqlite_datareader.GetString(0);
                string model = sqlite_datareader.GetString(1);

                //Console.WriteLine($"id: {id} manufactured: {manufactured}\tmodel: {model} \tyear_production: {year_production} \tid_clients: {id_clients}");
                Console.WriteLine($"{manufacturer}\t\t{model}");
            }
            Console.WriteLine();
        }
        static void ReadData7(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select min(year_birth) as 'older' from clients";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"-=-=-=--=-=    Query #7 \nolder");
            while (sqlite_datareader.Read())
            {
                int older = sqlite_datareader.GetInt32(0);
                Console.WriteLine($"{older}");
            }
            Console.WriteLine();
        }
        static void ReadData8(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT COUNT(id_clients) as 'Count avtomobile' FROM CARS WHERE id_clients = 1";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"-=-=-=--=-=    Query #8 \nolder");
            while (sqlite_datareader.Read())
            {
                int older = sqlite_datareader.GetInt32(0);
                Console.WriteLine($"{older}");
            }
            Console.WriteLine();
        }
        static void ReadData9(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            Console.ForegroundColor = ConsoleColor.Yellow;
            sqlite_cmd.CommandText = "select * " +
                                     "from clients " +
                                     "where id = " +
                                        "(SELECT id_clients " +
                                        "FROM cars " +
                                        "where year_production = " +
                                            "(select max(year_production)" +
                                            "from cars)" +
                                         ")";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Console.WriteLine($"-=-=-=--=-=    Query #9 \nid\tname\t\tyear_birth\tphone\t");
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                int year_birth = sqlite_datareader.GetInt32(2);
                int phone = sqlite_datareader.GetInt32(3);
                Console.WriteLine($"{id}\t{name}\t\t{year_birth}\t\t{phone}");
            }
            Console.WriteLine();
            //conn.Close();
        }

    }
}
