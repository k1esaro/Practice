Console.Clear();
string [] array = {"hello", "2", "world", ":-"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 3)
    {
        count++;
    } 
}
string [] result = new string[count];
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 3)
    {
        result[k]=array[i];
        k++;
    } 
}
for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]} ");
}