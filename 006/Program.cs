// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()
{
    Random random = new Random ();
    int rows = 3; 
    int columns = 3; 
    int [,] array = new int [rows, columns];
     FillArray(array);
     PrintArray(array);

    int sumMin = 0;
    int sumMinIndex = 0;

    for (int j=0; j < columns; j++)
        {
              sumMin += array [0, j];
        }  
Console.WriteLine($"сумма 1 строки равна: {sumMin}");

    for (int i=1; i < rows; i++)
    {
      int sum = 0;
      for (int j=0; j < columns; j++)
        {
             sum += array[i, j];
        }  
         Console.WriteLine($"сумма {i+1} строки равна: {sum}");
         if (sum < sumMin)
         {
           sumMin = sum;
           sumMinIndex = i;
         }
    }
    Console.WriteLine();
    Console.WriteLine($"минимальная сумма находится в строке {sumMinIndex + 1} и равна {sumMin}");


    void FillArray (int [,] array)
    { 
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++) 
       {
        array[i, j] = random.Next (0, 10); 
       }
    }
     }

     void PrintArray (int [,] array)
     {
       for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++) 
       {
        Console.Write(array[i, j] + "\t");
       }
       Console.WriteLine();
     }  
     }
      
     
}

Zadacha56();



