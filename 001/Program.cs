// задать двумерный массив и поменять первую строку и последнюю
void Zadacha53()
{
    Random random = new Random ();
    int rows = 3; 
    int columns = 4; 
    int [,] array = new int [rows, columns];
     FillArray(array);
     PrintArray(array);
     ChangeArray(array);
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
      
     void ChangeArray(int[,] array)
{
    int temp = 0;
    for (int j=0; j < columns; j++)
        {
            temp = array[0, j];
             array[0, j] = array[rows - 1, j];
             array[rows - 1, j] = temp;
        }
        Console.WriteLine();

}
}

Zadacha53();