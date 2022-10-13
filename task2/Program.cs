/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Введите количество строк  в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
GenerateArray(array);
Array1(array);
Console.WriteLine();

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

int GetTheSmallestSum = 0;
int sum = SumOfDigitsInLine(array, 0);

int SumOfDigitsInLine(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

for (int i = 1; i < array.GetLength(0); i++)
{
  int sum1 = SumOfDigitsInLine(array, i);
  if (sum > sum1)
  {
    sum = sum1;
    GetTheSmallestSum = i;
  }
}

Console.WriteLine($"{GetTheSmallestSum+1} строкa с наименьшей суммой  элементов ");