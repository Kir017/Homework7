// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void CreateFillArray()
{
  Console.WriteLine("Введите количество строк и столбцов в массиве (ввод числа через enter)");
  double[,] array = new double[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
  Console.WriteLine();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(Random.Shared.Next(-100, 100)) / 10;
      Console.Write($"| {array[i, j],5} | ");
    }
    Console.WriteLine();
  }
}
CreateFillArray();