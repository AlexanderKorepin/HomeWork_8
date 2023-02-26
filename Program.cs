// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] CreateRandomArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue+1);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
void ArrangeArrayRows(int indexRows, int[,]array)
{ 
    for(int i = 0; i < array.GetLength(0); i++)
    for(int j = i+1; j < array.GetLength(1); j++)
      if(array[indexRows,j] > array[indexRows,i])
      {
        int temp = array[indexRows,j];
        array[indexRows,j]= array[indexRows,i];
        array[indexRows,i] = temp;
      }
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateRandomArray(rows, columns, minValue,maxValue);
Show2dArray(newArray);
for(int i = 0; i < newArray.GetLength(0); i++)
      ArrangeArrayRows(i, newArray);
Show2dArray(newArray);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] CreateRandomArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue+1);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
int MinSumElementRows(int[,] array, int indexRows)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
      sum+=array[indexRows,i];
    return sum;
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateRandomArray(rows, columns, minValue,maxValue);
Show2dArray(newArray);
int minRows = 0;
for(int i = 0; i < newArray.GetLength(0); i++)
    if(MinSumElementRows(newArray, minRows) > MinSumElementRows(newArray, i))
        minRows = i;
Console.WriteLine("Row with minimal sum of elements is: " + (minRows+1) + " Rows!");
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] CreateRandomArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue+1);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}
int [,] MatrixMultiplication(int[,] matrix1, int [,] matrix2)
{
  int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
  for(int i = 0; i <  result.GetLength(0); i++)
      for(int j = 0; j < result.GetLength(1); j++)
          for(int y = 0; y < matrix1.GetLength(1); y++)
            result[i, j] += matrix1[i, y] * matrix2[y, j];
  return result;
}
Console.Write("Enter the number of rows  matrix 1 : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns  matrix 1: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [,] newMatrix1 = CreateRandomArray(rows, columns, minValue,maxValue);
Show2dArray(newMatrix1);

Console.Write("Enter the number of rows  matrix 2 : ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns  matrix 2: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());
int [,] newMatrix2 = CreateRandomArray(rows2, columns2, minValue2,maxValue2);

Console.WriteLine("Matrix 1:");
Show2dArray(newMatrix1);
Console.WriteLine("Matrix 2:");
Show2dArray(newMatrix2);

if(newMatrix1.GetLength(1) == newMatrix2.GetLength(0))
{
    int[,] newMatrix = MatrixMultiplication(newMatrix1, newMatrix2);
    Console.WriteLine("The result of multiplying two matrices is: ");
    Show2dArray(newMatrix);
}
else
    Console.WriteLine("Error!");
*/
//=========================================================================
// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] CreateRandomArray3D(int rows,int columns,int thick,int minValue, int maxValue)
{
  int [,,] array = new int[rows,columns, thick];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        for(int y = 0; y < thick; y++)
        {
          array[i,j,y] = new Random().Next(minValue, maxValue+1);
        }    
    return array;
}
void Show3dArray(int[,,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      for(int y = 0; y< array.GetLength(2); y++)
        Console.Write(array[i,j,y] + $"({i},{j},{y}) ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of thick: ");
int thick = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,,] newArray = CreateRandomArray3D(rows, columns, thick, minValue, maxValue);
Show3dArray(newArray);
*/
//=====================================================================
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}
int[,] SpiralArray(int rows, int cols)
{
  int[,] array = new int[rows, cols];
  int element = 1, minRows = 0, maxRows = rows - 1, minCol = 0, maxCol = cols - 1;
  while(element<= rows * cols)
  {
      for(int j = minCol; j <= maxCol; j++)
          array[minRows, j] = element++;
      minRows++;
      for(int i = minRows; i <= maxRows; i++)
          array[i, maxCol] = element++;
      maxCol--;
      for(int i = maxCol; i >= minCol; i--)
          array[maxRows, i] = element++;
      maxRows--;
      for(int i = maxRows; i >= minRows; i--)
          array[i, minCol] = element++;
      minCol++;
  }   
  return array;
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = SpiralArray(rows, columns);
Show2dArray(newArray);
*/

