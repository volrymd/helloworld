// Console.Clear();
// Console.Write("Введите число: ");
// int a1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int a2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int a3 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int b1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int b2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int b3 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int c1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int c2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int c3 = int.Parse(Console.ReadLine()!);

// int max = 0;

// if (a1>max) max = a1;
// if (a2>max) max = a2;
// if (a3>max) max = a3;
// if (b1>max) max = b1;
// if (b2>max) max = b2;
// if (b3>max) max = b3;
// if (c1>max) max = c1;
// if (c2>max) max = c2;
// if (c3>max) max = c3;

// Console.Write("Максимальное число: ");
// Console.WriteLine(max);


// int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result; 
// }

// int a1 = 18;
// int a2 = 23;
// int a3 = 94564;
// int b1 = 134;
// int b2 = 2345;
// int b3 = 213456;
// int c1 = 18;
// int c2 = 23;
// int c3 = 234;

// int max1 = Max(a1,a2,a3);
// int max2 = Max(b1,b2,b3);
// int max3 = Max(c1,c2,c3);
// int max = Max(max1,max2,max3);
// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);
// Console.WriteLine(max);


 
//  int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result; 
// }

// int a1 = 18;
// int a2 = 23;
// int a3 = 94564;
// int b1 = 134;
// int b2 = 2345;
// int b3 = 9856;
// int c1 = 18;
// int c2 = 23;
// int c3 = 234;


// int max = Max(
//     Max(a1,a2,a3),
//     Max(b1,b2,b3),
//     Max(c1,c2,c3));

// Console.WriteLine(max);
 

 
//  int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result; 
// }

// int[] array = {19,25,773,486,586,654,734,812,349};
// array[0] = 12;


// int max = Max(
//     Max(array[0],array[1],array[2]),
//     Max(array[3],array[4],array[5]),
//     Max(array[6],array[7],array[8]));

// Console.WriteLine(max);
 

// int [] array = {97,72,38,459,509,60,97,9};
// int n = array.Length;
// int find = 97;

// int index = 0;
// while (index<n)
// {if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
        }
        return position;
}

int[] array = new int[10]; //создать массив в котором будет 10 элементов

FillArray(array);
array[4] = 2;
array[6] = 2;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf (array, 56);
Console.WriteLine(pos);