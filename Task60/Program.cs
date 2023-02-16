/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

 Console.WriteLine($"\nВведите размер массива A x B x C:");
int A = InputNumbers("Введите A: ");
int B = InputNumbers("Введите B: ");
int C = InputNumbers("Введите C: ");
Console.WriteLine($"");

int[,,] array3D = new int[A, B, C];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"A({i}) B({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"C({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int A = 0; A < array3D.GetLength(0); A++)
  {
    for (int B = 0; B < array3D.GetLength(1); B++)
    {
      for (int C = 0; C < array3D.GetLength(2); C++)
      {
        array3D[A, B, C] = temp[count];
        count++;
      }
    }
  }
}