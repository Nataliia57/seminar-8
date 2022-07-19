// составить частотный словарь 

void Zadacha57()
{
    Random random = new Random ();
    int rows = 3; 
    int columns = 3; 
    int [,] array = new int [rows, columns];
    int [] d = new int [10];
     FillArray(array);
     PrintArray(array);

    for (int i=0; i < rows; i++)
    {
      for (int j=0; j < columns; j++)
        {
            d[array[i, j]]++;     
        }  
    }
    for (int i=0; i < d.Length; i++)
    {
        Console.WriteLine($"эллемент {i} встречается {d [i]} раз");
    }

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

Zadacha57();
