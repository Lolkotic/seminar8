//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк  в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
GenerateArray(array);
Array1(array);
Console.WriteLine();

PutDigitsInOrder(array);
Array1(array);


void GenerateArray(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(1,100);
    }
  }
}

void Array1(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}



void PutDigitsInOrder(int[,] array)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < m; j++)
    {
      for (int k = 0; k < m - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int arr = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = arr;
        }
      }
    }
  }
}





