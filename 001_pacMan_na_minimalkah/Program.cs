using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Preview()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Grasshoper();
            Console.CursorVisible = false;
            char[,] map =
            {
                {' ',' ',' ',' ',' ','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
                {' ',' ',' ',' ',' ','▓',(char)3,' ',' ',' ',' ',' ',' ',' ',(char)4,' ',' ',' ',' ',' ',' ',' ',(char)11,' ',' ',' ',' ',' ',(char)14,' ',' ','▓'},
                {' ',' ',' ',' ',' ','▓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▓'},
                {' ',' ',' ',' ',' ','▓',' ',' ','┳','┳','┓','┓','┏',' ','┏','┓','┳','┓','┏','┓','┏','┳','┏','┓','┏','┓','┏','┳','┓',' ',' ','▓'},
                {' ',' ',' ',' ',' ','▓',(char)169,' ','┃','┃','┃','┗','┫',' ','┃','┃','┣','┫','┃','┃',' ','┃','┣',' ','┃',' ',' ','┃',' ',' ',(char)167,'▓'},
                {' ',' ',' ',' ',' ','▓',' ',' ','┛',' ','┗','┗','┛',' ','┣','┛','┛','┗','┗','┛','┗','┛','┗','┛','┗','┛',' ','┻',' ',' ',' ','▓'},
                {' ',' ',' ',' ',' ','▓',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▓'},
                {' ',' ',' ',' ',' ','▓',(char)164,' ',' ',' ',' ',(char)6,' ',' ',' ',' ',' ',' ',(char)12,' ',' ',' ',' ',' ',(char)5,' ',' ',' ',' ',(char)165,' ','▓'},
                {' ',' ',' ',' ',' ','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'}
            };

            int userX = 2; int userY = 8;
            int score = 0;
            char[] bonus = new char[1];
            bool prev = true;

            while (prev)
            {

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        // символи букв
                        if ((int)map[i, j] > 9474 && (int)map[i, j] < 9532)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"{map[i, j]}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        // символи бонусів
                        else if ((int)map[i, j] > 2 && (int)map[i, j] < 170)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{map[i, j]}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        // символ стін
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write($"{map[i, j]}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"     Score: {score}");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"     Bonus:");
                for (int k = 0; k < bonus.Length; k++)
                {
                    Console.Write($"{bonus[k]}");
                }

                Console.SetCursorPosition(userY, userX);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine('Ơ');

                ConsoleKeyInfo charKey = Console.ReadKey();
                Console.Beep(440, 100);
                switch (charKey.Key)
                {
                    // крокуємо
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '▓')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '▓')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '▓')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '▓')
                        {
                            userY++;
                        }
                        break;
                    // виходимо з гри
                    case ConsoleKey.Enter:
                        prev = false;
                        break;

                }
                // затираємо при попаданні на MY PROJECT
                if ((int)map[userX, userY] > 9474 && (int)map[userX, userY] < 9532)
                {
                    Console.Beep(784, 150);
                    map[userX, userY] = ' ';
                    score++;
                }

                else if ((int)map[userX, userY] > 2 && (int)map[userX, userY] < 170 && (int)map[userX, userY] != 32)
                {
                    Console.Beep(784, 150);
                    char[] tempBonus = new char[bonus.Length + 1];
                    for (int i = 0; i < bonus.Length; i++)
                    {
                        tempBonus[i] = bonus[i];
                    }
                    tempBonus[tempBonus.Length - 1] = map[userX, userY];
                    bonus = tempBonus;
                    score++;
                    map[userX, userY] = ' ';
                }

                if (score == 63)
                {
                    prev = false;
                }
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"

░██████╗░░█████╗░███╗░░░███╗███████╗  ░█████╗░██╗░░░██╗███████╗██████╗░
██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██║░░░██║██╔════╝██╔══██╗
██║░░██╗░███████║██╔████╔██║█████╗░░  ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝
");
        }
        static void Main(string[] args)
        {
            Preview();
        }
    }
}
