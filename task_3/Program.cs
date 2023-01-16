// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateFillArray()
{
  Console.WriteLine("Введите количество строк и столбцов в таблице (ввод числа через enter)");
  int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
  Console.WriteLine();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToInt32(Random.Shared.Next(10));
      Console.Write($"|{array[i, j]}| ");
    }
    Console.WriteLine();
  }
  return array;
}

void GetMidleArithmetic(int[,] verifiableArray)
{
  double midleArr = 0;
  Console.WriteLine();
  for (int j = 0; j < verifiableArray.GetLength(0); j++)
  {
    for (int i = 0; i < verifiableArray.GetLength(1); i++)
    {
      midleArr += verifiableArray[i, j];
    }
    Console.WriteLine($"Среднее арифметическое чисел {j + 1} столбца = {Math.Round(midleArr / verifiableArray.GetLength(1), 2)}");
    midleArr = 0;
  }

}

int[,] array = CreateFillArray();
GetMidleArithmetic(array);
