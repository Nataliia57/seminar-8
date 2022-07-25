// Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Random random = new Random ();
    int rows = 5; 
    int columns = 5; 
    int [,] array = new int [rows, columns];
     FillArray(array);
     PrintArray(array);

    for (int i=0; i < rows; i++)
    {
      for (int j=0; j < columns; j++)
        {
              for (int k=0; k < columns - j - 1; k++)
           {
                if (array [i, k] < array [i, k+1])
                {
                  int temp = array[i, k];
                  array[i, k] = array[i, k+1];
                  array[i, k+1] = temp;
                }
           } 
        }  
    }
    Console.WriteLine();
    PrintArray(array);


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

Zadacha54();


