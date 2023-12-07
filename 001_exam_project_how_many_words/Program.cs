using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace how_many_words
{
    internal class Program
    {
        static void OutputVocabulary(string[] vocabulary)
        {
            // вивевдення словника на екран
            Array.Sort(vocabulary);
            //Array.Clear(vocabulary,0,vocabulary.Length);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n  Your vocabulary for verification (default):");
            Console.ForegroundColor = ConsoleColor.Cyan;

            string patern = new string((char)9552, 98);
            Console.WriteLine("  " + patern);

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < vocabulary.Length; i++)
            {
                Console.WriteLine($"  {i + 1:D2}. {vocabulary[i]}");
            }
        }
        static string[] StartView(bool flagStart, string[] vocabulary)
        {
            while (flagStart)
            {
                // ти хочеш внести зміни у словник?
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n  Do you want to change vocabulary?");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("  \tYES - 1\t\tNO - 2");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  ");
                string changeOrNo = Console.ReadLine();

                switch (changeOrNo)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n  Enter your words for verification (only text):");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("  ");
                        string inputWords = Console.ReadLine();
                        string[] newVocabulary = inputWords.ToLower().Trim().Split();
                        vocabulary = new string[newVocabulary.Length];
                        for (int i = 0; i < vocabulary.Length; i++)
                        {
                            vocabulary[i] = newVocabulary[i];
                        }

                        OutputVocabulary(vocabulary);
                        flagStart = false;
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("  Working with the current vocabulary :)");
                        flagStart = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  wrong answer");
                        break;
                }
            }
            return vocabulary;

        }

        static void OutputFirstLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n  Result...");

            Console.ForegroundColor = ConsoleColor.Cyan;
            //формуємо рамки: гору
            string patern = new string((char)9552, 98);
            string firstLine = (char)9556 + patern + (char)9559;
            Console.WriteLine("  " + firstLine);
        }
        static void OutputLastLine()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //формуємо рамки: низ
            string patern = new string((char)9552, 98);
            string lasttLine = (char)9562 + patern + (char)9565;

            Console.WriteLine("  " + lasttLine);
        }
        static string CleanText(string text)
        {
            // перелік символів, що треба прибрати
            char[] stopSymbols = {(char)13,(char)33,' ','"','#','$','%','&','\'','(',')','*','+',','/*,'-'*/,'.','/',
                '0','1','2','3','4','5','6','7','8','9',':','<','>','=',';','?','@','[',']','\\','^','_','`',
                '{','}','|','~',(char)145, (char)146, (char)147, (char)148,'\n','\r','\t'};

            // видаляємо непотрібні символи

            string[] data = text.ToLower().Split(stopSymbols);

            string cleanText = "";
            for (int i = 0; i < data.Length; i++)
            {
                cleanText += data[i];
            }

            return cleanText;
        }

        static string[,] ArrayFromWordSymbols(string word, string inputText)
        {
            char[] copyInputText = inputText.ToCharArray();
            // створюємо двумірний масив для відстежування символів та їх кількості
            string[,] countSymbolsInWord = new string[word.Length, 2];

            // беремо кожний символ слова
            for (int k = 0; k < word.Length; k++)
            {
                //Console.Write($"{word[k]} ");
                // зрівнюємо к-ий символ слова с кожним символом в очищеному тексті
                for (int j = 0; j < copyInputText.Length; j++)
                {
                    if (word[k] == copyInputText[j])
                    {
                        // якщо такий символ є - > при першому входженні заносимо символ і 1
                        if (countSymbolsInWord[k, 0] == null)
                        {
                            countSymbolsInWord[k, 0] = copyInputText[j].ToString();
                            countSymbolsInWord[k, 1] = "1";
                            copyInputText[j] = '+';
                        }
                        // при послідуючих повторах до лічильника +1
                        else
                        {
                            int temp = Convert.ToInt32(countSymbolsInWord[k, 1]) + 1;
                            countSymbolsInWord[k, 1] = temp.ToString();
                        }
                    }
                }
            }

            return countSymbolsInWord;
        }

        static int HowManyPossibleCreateWord(string[,] countSymbolsInWord, string word)
        {
            //-=-=-=-=-=-=-=-=-=-=  рахуємо скільки раз можна утворити слово  -=-=-=-=-=-=-=-=-=-=-==-=-
            //ідея: взяти кількість символів із масиву - скопіювати з перевіркою на пусті значення
            // якщо є пусті значення - 0 слів
            // якщо пустих нема - беремо мінмальне значення з масиву
            // це і буде кількість слів

            // беремо 2гу колоку матриці countSymbolsInWord - > створюємо 1но вимірний масив
            // якщо є NULL  зміна   flag на ІСТИНА

            int[] arrayOfCountSymbols = new int[word.Length];
            int countWords = int.MaxValue;

            //перевірка чи є значення NULL
            // спочатку ставимо ХИБА, якщо знайдемо NULL, то ставимо ІСТИНА
            bool flag = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (countSymbolsInWord[i, 1] != null && flag == false)
                {
                    arrayOfCountSymbols[i] = Int32.Parse(countSymbolsInWord[i, 1]);
                }
                else
                {
                    countWords = 0;
                    flag = true;
                    break;
                }
            }

            // вибираємо мінімальне число, flag = false
            if (flag != true)
            {
                //використовуємо фреймворк Linq
                countWords = arrayOfCountSymbols.Min();
            }
            // якщо є хоча б 1  NULL - вертаємо 0
            else
            {
                countWords = 0;
            }
            return countWords;
        }

        static void OutPutResult(string inputText, string[] vocabulary)
        {
            for (int i = 0; i < vocabulary.Length; i++)
            {
                string word = vocabulary[i];
                //метод, що створює масив під поточне слово та заповнює символами, що співпадають
                string[,] countSymbolsInWord = ArrayFromWordSymbols(word, inputText);

                //метод, що рахує можливість утворення слова із наявних сиволів
                int wordCount = HowManyPossibleCreateWord(countSymbolsInWord, word);
                string countDigit = wordCount.ToString();

                //віводимо результат по кожному слову із словника
                Console.ForegroundColor = ConsoleColor.Cyan;
                int leftMargin = 50 - 1 - word.Length - 2 - countDigit.Length;
                string paternLeft = new string(' ', leftMargin);
                Console.Write($"  {(char)9553}{paternLeft}");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{word}: {wordCount}");

                Console.ForegroundColor = ConsoleColor.Cyan;
                string paternRight = new string(' ', 49);
                Console.Write($"{paternRight}{(char)9553}\n");

            }
        }

        static void Main(string[] args)
        {
            Console.WindowWidth = 104;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
  ▓                                                                                                ▓
  ▓                                    ┳┳┓┓┏  ┏┓┳┓┏┓┏┳┏┓┏┓┏┳┓                                      ▓
  ▓                                    ┃┃┃┗┫  ┃┃┣┫┃┃ ┃┣ ┃  ┃                                       ▓
  ▓                                    ┛ ┗┗┛  ┣┛┛┗┗┛┗┛┗┛┗┛ ┻                                       ▓
  ▓                                                                                                ▓
  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
                       ");
            bool flagBody = true;
            while (flagBody == true)
            {
                //// словник
                string[] vocabulary = { "apple", "коваль", "їжак", "яблоко", "ball", "dog", "cat", "dall", "one", "zero", "table" };

                OutputVocabulary(vocabulary);

                bool flagStart = true;
                vocabulary = StartView(flagStart, vocabulary);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n  Input your text for verification:");

                Console.ForegroundColor = ConsoleColor.Green;
                // отримуємо вхідний текст, переводимо до нижньго реєстру
                Console.Write("  ");

                // розширяємо буфер для збільшення кількості символів тексту, що вводимо
                int bufSize = 10000;
                Stream inStream = Console.OpenStandardInput(bufSize);
                Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));

                string inputText = CleanText(Console.ReadLine()).ToLower();
                OutputFirstLine();

                Console.ForegroundColor = ConsoleColor.White;

                OutPutResult(inputText, vocabulary);

                //виводимо нижню рамку
                OutputLastLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n  Do you want to check the text again?");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("  \tYES - 1\t\tNO - 2");

                bool flagExit = true;
                while (flagExit)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("  ");
                    string changeOrNo = Console.ReadLine();

                    switch (changeOrNo)
                    {
                        case "1":
                            flagExit = false;
                            Console.Clear();
                            break;

                        case "2":
                            flagExit = false;
                            flagBody = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("  wrong answer");
                            break;
                    }
                }


            }

        }

    }
}
/*
 
1. Вивоводимо "Your vocabulary for verification (default)"
   |
   v
2. Виводимо поточний словник на екран, відсортованого за алфавітом
   |
   v
3. Виводимо питання: "Do you want to change vocabulary?"
   |
   |---> Варіанти відповідей: "YES - 1" чи "NO - 2"
   |     |
   |     |---> Якoщо обрано "1" (YES):
   |     |     |
   |     |     v
   |     |   Вводимо нові слова для перевірки через пробіл
   |     |     |
   |     |     v
   |     |   Створення нового словника
   |     |     |
   |     |     v
   |     |   Виводимо оновлений словник
   |     |     |
   |     |     v
   |     |   Вихід из циклу вибору
   |     |
   |     |---> Якoщо обрано "2" (NO):
   |     |     |
   |     |     v
   |     |   Виводимо "Working with the current vocabulary :)"
   |     |     |
   |     |     v
   |     |   Вихід из циклу вибору
   |     |  
   |     |---> Якщо введено інший сивол(и)
   |     |     |
   |     |     v
   |     |    Виведення Wrong answer - повтор питання "Do you want to change vocabulary?"
   |
4. Введення текста для перевірки
   |
   |---> Очистка тексту овід зайвих символів
   |     |
   |     v
   |   Введення "Result..."
   |     |
   |     v
   |   Виведення рамки зверху
   |     |
   |     v
   |   Для кожного слова в словнику:
   |   |
   |   |---> Створення двумірного масиву countSymbolsInWord
   |   |     |
   |   |     v
   |   |   Для кожного символу в слові:
   |   |   |
   |   |   |---> Для кожного символу в очищеному тексті:
   |   |   |     |
   |   |   |     |---> Якщо символи співпадають:
   |   |   |     |     |
   |   |   |     |     v
   |   |   |     |   Збільшуємо лічильник символа в countSymbolsInWord
   |   |   |     |
   |   |   |     v
   |   |   |
   |   |   |---> Підрахунок, скільки раз можно зібрати слово із символів, що співпали
   |   |   |     |
   |   |   |     v
   |   |   |   Збереження результата в wordCount
   |   |   |
   |   |   |---> Виводимо на екран слова та wordCount
   |   |
   |   |---> Виведення рамки внизу
   |     |
   |     v
   |
5. Віводимо питання: "Do you want to check the text again?"
   |
   |---> Варіанти відповідей: "YES - 1" або "NO - 2"
   |     |
   |     |---> Якoщо обрано "1" (YES):
   |     |     |
   |     |     v
   |     |   Очистка екрану
   |     |     |
   |     |     v
   |     |   Перезапускаємо весь цикл прогарми заново
   |     |
   |     |---> Якoщо обрано "2" (NO):
   |     |     |
   |     |     v
   |     |   Завершення програми
   |     |  
   |     |---> Якщо введено інший сивол(и)
   |     |     |
   |     |     v
   |     |    Виведення Wrong answer - повтор питання "Do you want to check the text again?"
   |
6. Завершення програми




//      __  ___                    __                                                               __  
//     /  |/  /   __  __          / /_   ____    ____ ___   ___         _      __  ____    _____   / /__
//    / /|_/ /   / / / /         / __ \ / __ \  / __ `__ \ / _ \       | | /| / / / __ \  / ___/  / //_/
//   / /  / /   / /_/ /         / / / // /_/ / / / / / / //  __/       | |/ |/ / / /_/ / / /     / ,<   
//  /_/  /_/    \__, /         /_/ /_/ \____/ /_/ /_/ /_/ \___/        |__/|__/  \____/ /_/     /_/|_|  
//             /____/                                                                                   




//  ┳┳┓    ┓                 ┓ 
//  ┃┃┃┓┏  ┣┓┏┓┏┳┓┏┓  ┓┏┏┏┓┏┓┃┏
//  ┛ ┗┗┫  ┛┗┗┛┛┗┗┗   ┗┻┛┗┛┛ ┛┗
//      ┛                      



//                                d8,                       
//                               `8P                   d8P  
//                                                  d888888P
//  ?88,.d88b,  88bd88b d8888b   d88   d8888b d8888b  ?88'  
//  `?88'  ?88  88P'  `d8P' ?88  ?88  d8b_,dPd8P' `P  88P   
//    88b  d8P d88     88b  d88   88b 88b    88b      88b   
//    888888P'd88'     `?8888P'   `88b`?888P'`?888P'  `?8b  
//    88P'                         )88                      
//   d88                          ,88P                      
//   ?8P                       `?888P                       


//                                                                       
//  @@@@@@@   @@@@@@@    @@@@@@        @@@  @@@@@@@@   @@@@@@@  @@@@@@@  
//  @@@@@@@@  @@@@@@@@  @@@@@@@@       @@@  @@@@@@@@  @@@@@@@@  @@@@@@@  
//  @@!  @@@  @@!  @@@  @@!  @@@       @@!  @@!       !@@         @@!    
//  !@!  @!@  !@!  @!@  !@!  @!@       !@!  !@!       !@!         !@!    
//  @!@@!@!   @!@!!@!   @!@  !@!       !!@  @!!!:!    !@!         @!!    
//  !!@!!!    !!@!@!    !@!  !!!       !!!  !!!!!:    !!!         !!!    
//  !!:       !!: :!!   !!:  !!!       !!:  !!:       :!!         !!:    
//  :!:       :!:  !:!  :!:  !:!  !!:  :!:  :!:       :!:         :!:    
//   ::       ::   :::  ::::: ::  ::: : ::   :: ::::   ::: :::     ::    
//   :         :   : :   : :  :    : :::    : :: ::    :: :: :     :     
//       



//  +-+ +-+  +-+ +-+ +-+ +-+ +-+ +-+ +-+
//  |M| |Y|  |P| |R| |O| |J| |E| |C| |T|
//  +-+ +-+  +-+ +-+ +-+ +-+ +-+ +-+ +-+


//  ┏┓┳┓┏┓┏┳┏┓┏┓┏┳┓
//  ┃┃┣┫┃┃ ┃┣ ┃  ┃ 
//  ┣┛┛┗┗┛┗┛┗┛┗┛ ┻ 
//                 

//  ┳┳┓    ┏┓┳┓┏┓┏┳┏┓┏┓┏┳┓
//  ┃┃┃┓┏  ┃┃┣┫┃┃ ┃┣ ┃  ┃ 
//  ┛ ┗┗┫  ┣┛┛┗┗┛┗┛┗┛┗┛ ┻ 
//      ┛                 


Font Name: tmplr



 
*/