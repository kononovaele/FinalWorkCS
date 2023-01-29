
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetInputString()
{
    Console.Write("\nInput string, where delimiter is comma, please: ");
    Console.Write("\nExample: 123, fgf, fdfdfds, rrrrr, 333, (^d");

    string? strInput = Console.ReadLine();
    if( String.IsNullOrEmpty(strInput) == true)
        strInput = "0";

    String[] spearator = { "," };
  
    String[] strlist = strInput.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

    return strlist;
}

void PrintStringArray(string[] strArray)
{
    foreach(string str in strArray)
    {
       Console.WriteLine($"\"{str}\" "); 
    }
}

string[] TrimStringArray(string[] strArray)
{
    for(int i = 0; i < strArray.Length; ++i)
    {
        strArray[i] = strArray[i].Trim();
    }
    return strArray;
}

string[] GetEmptyStringArray(string[] strArray)
{
    int arrayLen = 0;
    foreach(string str in strArray)
    {
        if(str.Length <= 3)
            arrayLen = arrayLen + 1;
    }
    return new string[arrayLen];
}

string[] GetStringArrayThreeLE(string[] strArray, string[] strArrayThreeLE)
{
    int i = 0;
    foreach(string str in strArray)
    {
        if(str.Length <= 3) {
            strArrayThreeLE[i] = str;
            i = i + 1;
        }
    }
    return strArrayThreeLE;
}

void main()
{
    Console.WriteLine(" ------- Final work -------");

    // Получить строку ввода целых чисел. Это строка вида: "N M P" задает размер матрицы и число, которое мы ищем в матрице
    // Пример : " 5 4 17", матрица размером 5 на 4 и мы ищем число 17 в матрице
    string[] strArray = GetInputString();
    strArray = TrimStringArray(strArray);
    PrintStringArray(strArray);

    string[] strArrayThreeLE = GetEmptyStringArray(strArray);

    strArrayThreeLE = GetStringArrayThreeLE(strArray, strArrayThreeLE);
    PrintStringArray(strArrayThreeLE);

}

main();
