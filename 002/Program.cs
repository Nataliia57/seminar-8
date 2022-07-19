// задать двумерный массив который поменяет строки на столбцы

void Zadacha55()
{
    Random random = new Random ();
    int rows = 4; 
    int columns = 4; 
    int [,] array = new int [rows, columns];
     FillArray(array);
     PrintArray(array);
     ChangeRowsColumns(array);
     PrintArray(array);

    void FillArray (int [,] array)
    { 
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++) 
       {
        array[i, j] = random.Next (1, 10); 
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
      
     void ChangeRowsColumns(int[,] array)
{
    for (int i=0; i < rows; i++)
    {
      for (int j=i; j < columns; j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array [i, j]);     
        }  
    }
    
        Console.WriteLine();

}
}

Zadacha55();