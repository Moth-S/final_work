//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

//задаем размер основного массива
Console.Write("Array length:");
int size = Convert.ToInt16(Console.ReadLine());

///создание и заполнение массива
string[] GetArray(int size)
{
    // создается массив размером size
    string[] array = new string[size];

    //заполнение массива
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(Console.Read());
    }

    return array;
}

///вывод массива на экран
void PrintArray(string[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}    ");
    }
}

///метод считает кол-во элементов с длиной <=3
int CountWord(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }

    return count;
}

string[] SearchElement(string[] arr, int size)
{
    string[] array2 = new string[size];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array2[count]=arr[i];
            count+=1;
        }
    }
    return array2;
}

string[] array1 = GetArray(size);
Console.WriteLine("Start array: ");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Result array: ");
PrintArray(SearchElement(array1,CountWord(array1)));





