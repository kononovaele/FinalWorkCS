
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetInputString()
{
    Console.Write("\nInput two digits (M N) of integer, please: ");

    string? strInput = Console.ReadLine();
    if( String.IsNullOrEmpty(strInput) == true)
        strInput = "0";

    //string[] array = strInput.Split().Select().ToArray();
    String[] spearator = { "," };
  
        // using the method
    String[] strlist = strInput.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

    return strlist;
}

void PrintStringArray(string[] strArray)
{

    foreach(string str in strArray)
    {
       Console.WriteLine($"{str} "); 
    }
}

void main()
{
    Console.WriteLine(" ------- Final work -------");

    // Получить строку ввода целых чисел. Это строка вида: "N M P" задает размер матрицы и число, которое мы ищем в матрице
    // Пример : " 5 4 17", матрица размером 5 на 4 и мы ищем число 17 в матрице
    string[] strArray = GetInputString();
    PrintStringArray(strArray);

    // Если были введены целые числа с разделителем запятая "," то заменяем запятую на пробел " "
    //strDigits = GetNormilizeStrOfIntegers(strDigits);

    // Получим массив строк, где строка - целое число в виде строки
    //string[] wordsOfNumbers = GetStrArrayOfNumvers(strDigits);

    // Конвертируем массив строк в массив целых числех
    //int[] arrayOfDigits = GetConvertStrArrayToArrayInt(wordsOfNumbers);

    //int row = arrayOfDigits[0];
    //int col = arrayOfDigits[1];

    // Создать квадратную матрицу вещественных чисел и заполнить ее
    //int[,] matrix = GetMatrixInt(row, col);

    // Печатаем матрицу
    //PrintMatrix(row, col, matrix);

    // Получим массив среднеарифмитических чисел. Размер массива - col
    // double[] arrayОfАverages = GetArrayОfАverages(row, col, matrix);

    // Печатаем результат (красиво), количество введенных чисел больше нуля
    //PrintRezult(arrayОfАverages, col);
}

main();
