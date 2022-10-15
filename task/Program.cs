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
        array[i]=Console.ReadLine();
    }

    return array;
}

