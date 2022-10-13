namespace Две_Игры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            do
            {
                Console.WriteLine("Выберите программу: 1. Игра Угадай число;  2. Таблица умножения;   3. Выход");
                string chislo = Console.ReadLine();
                int b = Convert.ToInt32(chislo);

                if (b == 1)
                {
                    Ugadai_chislo();
                }

                else if (b == 2)
                {
                    Tablica();
                }

                else if (b == 3)
                {
                    Console.WriteLine("Завершение программы");
                    a = false;
                }

            } while (a == true);
        }
        static void Ugadai_chislo()
        {

            bool n = true;
            Random chislo = new Random();
            int l = chislo.Next(0, 100);
            do
            {
                Console.WriteLine("Введите предполагаемое число");
                string k = Console.ReadLine();
                int a = Convert.ToInt32(k);
                Console.Clear();

                Console.WriteLine("Для подсказки нажмите F1");
                ConsoleKeyInfo g = Console.ReadKey();
                if (g.Key == ConsoleKey.F1)
                {
                    int c = l / 2;
                    if (c == 1)
                    {
                        Console.WriteLine("Число нечётное");
                    }
                    else
                    {
                        Console.WriteLine("Число чётное");
                    }


                }
                if (a > l)
                {
                    Console.WriteLine("Число меньше");
                }
                else if (a < l)
                {
                    Console.WriteLine("Число больше");
                }
                else if (a == l)
                {
                    Console.WriteLine("Вы победили");
                    n = false;
                }
                
            } while (n == true);




        }
        static void Tablica()
        {

            int[,] tabl = new int[10, 9];
            for (int i = 1; i < 10; i++)
            {
                for (int v = 1; v < 9; v++)
            {
                    tabl[i, v] = i * v;
                    Console.WriteLine(tabl[i, v] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}