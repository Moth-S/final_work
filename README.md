# final_work

Контрольная работа после прохождения обучения (Вводный блок курса "Разработчик")

Необходимо решить задачу: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Решение и блок-схема в репозитории.

Этапы решения:
1. С клавиатуры задается размер основного массива.
2. Добавлен метод для создания и заполнения строкового массива с клавиатуры.(GetArray)
3. Добавлен метод для печати массива (PrintArray)
4. Добавлен метод, который вычисляет количество элементов в основном массиве с длиной <= трем, путем перебора элементов массива.(CountWord) 
   Это позволит задать размер второго массива, в котором будут хранится искомые элементы.
5. Добавлен метод, который создает новый массив, перебирает элементы исходного массива, и если встречается элемент с длиной <=3, добавляет в новый.(SearchElement)
6. В переменную array1 передается результат вызова функции (GetArray).
7. Выводится на экран исходный массив
8. Выводится результирующий массив, полученный после вызова метода SearchElement с длиной, которую вернул метод CountWord.


Также прилагается блок-схема. (в схеме не отражены алгоритмы методов)
