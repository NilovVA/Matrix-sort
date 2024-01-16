using System;
class Program
{
    static void Sort(int[,] a)
    {
        int temp;
        for (int line = 0; line < a.GetLength(0); line++)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[line, i] > a[line, j])
                    {
                        temp = a[line, i];
                        a[line, i] = a[line, j];
                        a[line, j] = temp;
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[,] a;
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Random rand = new Random();
        a = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[i, j] = rand.Next(0, 10);
            }
        }
        Console.WriteLine("Вывожу массив:");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();

        }




        Console.WriteLine("Сортировка по строкам:");
        Sort(a);
        Console.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();

        }
    }
}
