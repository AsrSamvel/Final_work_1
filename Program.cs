// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] CreateNewArray (string[] array)
{
  int j = 0;
  string[] newArray = new string[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3) 
    {
    newArray[j] = array[i];
    j++;
    }
  }
  return newArray;
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

Console.WriteLine("How many words will be in the array?");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the words in the array:");
string[] mainArray = new string[size];
for (int i = 0; i < mainArray.Length; i++)
  {
    mainArray[i] = Console.ReadLine(); 
  } 
string[] newArray = CreateNewArray(mainArray);
PrintArray(newArray);