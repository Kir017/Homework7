// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateFillArray()
{
  Console.WriteLine("Введите количество строк и столбцов в массиве (ввод числа через enter)");
  int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
  Console.WriteLine();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToInt32(Random.Shared.Next(10, 100));
      Console.Write($"|{array[i, j],3} | ");
    }
    Console.WriteLine();
  }
  return array;
}

void GetElementArray(int[,] verifiableArray)
{
  Console.Write("Введите индекс строки :");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите индекс столбца :");
  int colums = Convert.ToInt32(Console.ReadLine());
  if (rows < verifiableArray.GetLength(0) & colums < verifiableArray.GetLength(1))
  {
    Console.WriteLine($"Элемент массива по индексу {rows},{colums} = |{verifiableArray[rows, colums]}|");
  }
  else Console.WriteLine($"Элемент массива по индексу {rows},{colums} не существует");
}


int[,] array = CreateFillArray();
GetElementArray(array);