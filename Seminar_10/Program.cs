/*
// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве,
// начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

void FindOfLine(string[] array)
{
    int beginWithVowel = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i][0] == 'a' || array[i][0] == 'e' || array[i][0] == 'i' ||
            array[i][0] == 'o' || array[i][0] == 'u' || array[i][0] == 'y')
            beginWithVowel++;
    }
    Console.WriteLine("The number of words in the array"
                    + " starting with a vowel letter is equal to " + beginWithVowel);
}
string[] arr = { "qwe", "wer", "ert", "rty", "tyu" };
FindOfLine(arr);

*/

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив,
// объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] CreateArray(string[] array)
{
    string[] arr = new string[array.Length / 2];
    for (int i = 0, j = 0; i < array.Length - 1; i += 2, j++)
    {
        arr[j] = array[i] + array[i + 1];
        Console.Write(arr[j] + " ");
    }
    return arr;
}
string[] myArray = { "qwe", "wer", "ert", "rty", "tyu", "yui" };
CreateArray(myArray);
