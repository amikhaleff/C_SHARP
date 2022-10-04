// Первая группа методов - НЕ возвращает и не принимает

// void Method_1()
// {
//     System.Console.WriteLine("Author....");
// }

// Method_1();


// Вторая группа методов - Принимает, но не возвращает

// void Method_2(string msg)
// {
// System.Console.WriteLine(msg);
// }
// Method_2("text");


// void Method_21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
// {
//         System.Console.WriteLine(msg);
//     i++; // увеличение счетчика - инкримент
// }
// }
// Method_21("text", 5);
// Method_21(count: 5, msg: "new text"); // именовынные аргументы

// Третья группа методов - Возвращаю , но не принимают

// int Method_3()
// {
//     return DateTime.Now.Year;
// }

// int year= Method_3();
// System.Console.WriteLine(year);

// Четвертая группа методов - принимает и возвращает

// string Method_4(int count, string text)
// {
// int i=0;
// string result= string.Empty;
// while (i<count)
// {
// result=result+text;
// i++;
// }
// return result;
// }
// string res= Method_4(7, "Andrey ");
// System.Console.WriteLine(res);

// string Method_4(int count, string text) // С циклом 'for'
// {

// string result= string.Empty;
// for (int i=0;i<count;i++)// начальная переменная, проверка условия, счетчик
// {
// result=result+text;
// }
// return result;
// }
// string res= Method_4(7, "Andrey ");
// System.Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     System.Console.WriteLine();

// }


// string text = "Вначале идет тип переменной, потом ее имя. В качестве имени переменной может выступать любое произвольное название, которое удовлетворяет следующим требованиям:"
//     + "имя может содержать любые цифры, буквы и символ подчеркивания, при этом первый символ в имени должен быть буквой или символом подчеркивания";


// string Replace(string text, char OldValue, char NewValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == OldValue) result = result + $"{NewValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string NewText = Replace(text, ' ', '_');// char - заключается в одинарные кавычки
// System.Console.WriteLine(NewText);
// System.Console.WriteLine();

// string NewText1 = Replace(NewText, 'л', 'Л');
// System.Console.WriteLine(NewText1);
// System.Console.WriteLine();

// string NewText2 = Replace(NewText1, 'с', 'С');
// System.Console.WriteLine(NewText2);


// Упорядочивание массива

int[] array = { 1, 5, 77, 99, 3, 9, 2, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxpos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxpos]) maxpos = j;
        }
        int temp = array[i];
        array[i] = array[maxpos];
        array[maxpos] = temp;
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
   
    
}

PrintArray(array);
SortArray(array);