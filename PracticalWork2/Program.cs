using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите программу для выполнения\n1) Игра 'Угадай число'\n2) Таблица умножения\n3) Вывод делителей числа\n4) Закрыть программу");
                switch (Console.ReadLine())
                {
                    case "1":
                        program1();
                        break;
                    case "2":
                        program2();
                        break;
                    case "3":
                        program3();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void program1()
        {
            int answer = 0, randomNumber;
            Random random = new Random();
            randomNumber = random.Next(0, 100);
            Console.WriteLine("Угадай число от 0 до 100");
            while (answer != randomNumber)
            {
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer > randomNumber)
                {
                    Console.WriteLine("Ваше число слишком большое");
                }
                if (answer < randomNumber)
                {
                    Console.WriteLine("Ваше число слишком маленькое");
                }
            }
            Console.WriteLine("Вы угадали");
        }
        static void program2()
        {
            int[,] table = new int[10, 10];
            table[0, 0] = 1;
            for (int inum = 1; inum < 10; inum++)
                table[inum, 0] = table[inum - 1, 0] + 1;
            for (int inum = 1; inum < 10; inum++)
                table[0, inum] = table[0, inum - 1] + 1;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    table[i, j] = table[i, 0] * table[0, j];
                }
            }

            for (int colomn = 0; colomn < 10; colomn++)
            {
                for (int row = 0; row < 10; row++)
                {
                    Console.Write((colomn + 1) + "x" + (row + 1) + "=" + table[colomn, row] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void program3()
        {
            Console.WriteLine("Чтобы выйти введите слово 'выход'");
            int number;
            string input;
            do
            {
                input = Console.ReadLine();


                if (input != "выход" && int.TryParse(input,out number))
                {
                    number = Convert.ToInt32(input);
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.Write(i + "\t");
                        }
                    }
                }
                Console.WriteLine();
            } while (input != "выход");
        }
    }
}
