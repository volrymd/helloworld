// **Метод №1 (ничего не принимает, ничего не возвращает)**

// void Method1()
// {
// Console.WriteLine("Автор ... ");
// }

// Method1();

// **Метод №2 (принимает, но не возвращает)**

// void Method2 (string msg)
// {
//     Console.WriteLine (msg);
// }
// Method2("Текст сообщения");

// Может быть несколько аргументов у метода:

// void Method21 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine (msg);
//         i++;
//     }
// }

// // Method21("Текст", 4);
// // Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");

// **Метод №3 (ничего не принимает, но возвращает)**

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine (year);

// **Метод №4 (принимает аргументы и возвращает данные)**

// string Method4 (int count, string text)

// {
//     int i = 0;
//     string result = String.Empty; //пустая строка
//     while (i<count)
//         {
//             result = result + text;
//             i++;
//         }
//     return result;
// }

// string res = Method4 (10, "adsf ");

// Console.WriteLine(res);

// **Вариант метода с циклом for**

// string Method4 (int count, string text)
// {
//     string result = String.Empty; //пустая строка
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4 (10, "adsf ");
// Console.WriteLine(res);

// **Цикл в цикле (for) // Пример, с таблицей умножения**

// for (int i = 2; i<=10; i++)
// {
//     for (int j = 2; j<=10; j++)
//     {
//         Console.WriteLine ($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// **Работа с текстом.**

// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие буквы “С” заменить маленькими “с”.

// string text = " - Я думаю, - Сказал князь, улыбаясь, - что, "
//             + "ежели бы вас поСлали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i<length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
// return result;
// } 

// string newText = Replace (text, ' ', '|' );
// Console.WriteLine (newText);
// Console.WriteLine ();
// newText = Replace (newText, 'к', 'К');
// Console.WriteLine (newText);
// Console.WriteLine ();
// newText = Replace (newText, 'С', 'с');
// Console.WriteLine (newText);
// Console.WriteLine ();


// **Упорядочение массива (метод минимум/максимум)**

// int [] arr = {1,5,4,3,2,6,7,1,1};

// void PrintArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write ($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort (int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i+1; j<array.Length; j++)
//         {
//             if (array[j] < array [minPosition]) minPosition = j;
//         }
//     int temprorary = array [i];
//     array [i] = array [minPosition];
//     array [minPosition] = temprorary;
//     }
// }

// PrintArray (arr);
// SelectionSort(arr);
// PrintArray (arr);

// **САМЫЙ БОЛЬШОЙ ЭЛЕМЕНТ(упорядочить массив в обратную сторону)?**

int [] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++) 
    {
        Console.Write ($"{array[i]} ");
    }
Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j<array.Length; j++)
        {   
            if (array[j] > array [maxPosition]) maxPosition = j;
        }
    int temprorary = array [i];
    array [i] = array [maxPosition];
    array [maxPosition] = temprorary;
}
}

PrintArray (arr);
SelectionSort(arr);
PrintArray (arr);