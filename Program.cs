
string[] array1 = new string[] {"Нello", "Denmark", "-2", ":)"};
string[] array2 = new string[array1.Length];
void Array(string[] array1, string[] array2)
{
    int y = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[y] = array1[i];
        y++;
        }
    }
}   
void PrintArray(string[] array)
{
  Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write("]");
}
Array(array1, array2);
PrintArray(array2);
