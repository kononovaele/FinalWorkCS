
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Вводим строку символов
// Возвращает массив строк, без разделителя
string[] GetInputString()
{
    Console.Write("\nInput string, where delimiter is comma");
    Console.Write("\nExample: 123, fdfdfds, rrrrr, 333, (^d, 777: ");
    Console.Write("\nInput, please: ");

    string? strInput = Console.ReadLine();
    if( String.IsNullOrEmpty(strInput) == true)
        strInput = "";

    String[] spearator = { "," };
  
    String[] strlist = strInput.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

    return strlist;
}

// Печатаем массив строк
void PrintStringArray(string[] strArray)
{

    Console.Write("[");
    for(int i = 0; i < strArray.Length; ++i)
    {
        if( i == strArray.Length - 1)
            Console.Write($"\"{strArray[i]}\"");
        else
            Console.Write($"\"{strArray[i]}\", ");
    }
    Console.Write("]");
}

// Удаяем пробелы из строк массива
// Возвращает массив строк без пробелов
string[] TrimStringArray(string[] strArray)
{
    for(int i = 0; i < strArray.Length; ++i)
    {
        strArray[i] = strArray[i].Trim();
    }
    return strArray;
}

// Создаем новый массив строк (пустой), размером с количества строк из входного массива, где строка входящего массива <=3
// Возвращает новый пустой массив строк
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

// Заполняем массив строками из другого массива строк, где строка <= 3
// Возвращает заполненный массив строк
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

    // Получить строку символов (любых), раздедитель символов - запятая ","
    // Пример : Hello, 2, world, :-)
    string[] strArray = GetInputString();

    // Удаляем пробелы в веденных строках
    strArray = TrimStringArray(strArray);
    PrintStringArray(strArray);

    // Получим массив строк (пустой), длинной в колличестве строк, где число символов в строке <= 3
    string[] strArrayThreeLE = GetEmptyStringArray(strArray);

    // Заполним массив строк, строками из другого массива строк, где число символов в строке <= 3
    strArrayThreeLE = GetStringArrayThreeLE(strArray, strArrayThreeLE);
    Console.Write(" => ");
    PrintStringArray(strArrayThreeLE);

}

main();
