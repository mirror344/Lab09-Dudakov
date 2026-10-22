//Задание 1
// Console.Write("Введите слово: ");
// string word = Console.ReadLine();
// int count = 0;

// foreach (char c in word.ToLower())
// {
//     if (c == 'а')
//     {
//         count += 1;
//     }
// }

// Console.WriteLine($"Буква а встречается {count} раз");

//Задание 2
// Console.Write("Имя файла: ");
// string fileName = Console.ReadLine();

// if (fileName.EndsWith(".cs"))
// {
//     Console.WriteLine("Это файл C#");
// }
// else if (fileName.EndsWith(".png"))
// {
//     Console.WriteLine("Это изображение");
// }
// else if (fileName.EndsWith(".jpg"))
// {
//     Console.WriteLine("Это изображение");
// }
// else
// {
//     Console.WriteLine("Неизвестный тип");
// }

// if (fileName.StartsWith("Lab"))
// {
//     Console.WriteLine("Это лабораторная работа");
// }
// if (fileName.Contains("test"))
// {
//     Console.WriteLine("Текстовый файл");
// }

//Задние 3
// Console.Write("Введите фразу: ");
// string str = Console.ReadLine();

// Console.WriteLine($"{str.ToUpper()}");
// Console.WriteLine($"{str.Replace(" ", "_")}");
// if (str.ToLower().Contains("стоп"))
// {
//     Console.WriteLine("Стоп-слово найдено!");
// }

//Задание 4 
// Console.Write("Введите дату (yyyy-mm-dd): ");
// string data = Console.ReadLine();
// string day = data.Substring(8);
// string month = data.Substring(5, 2);
// string year = data.Substring(0, 4);
// Console.WriteLine($"{day}.{month}.{year}");

// Console.Write("Введите номер (например, 89161234567): ");
// string number = Console.ReadLine();

// Console.WriteLine($"+7 ({number.Substring(1, 3)}) {number.Substring(4, 3)}-{number.Substring(7, 2)}-{number.Substring(9, 2)}");

//Задание 5
// Console.Write("Введите строку: ");
// string str = Console.ReadLine();
// int count_s = 0;
// int count_v = 0;
// string check = "аеёиоуыэюя";

// foreach (char c in str)
// {
//     if (check.Contains(c))
//     {
//         count_v++;
//     }

//     if (c == ' ')
//     {
//         count_s++;
//     }
// }


// Console.WriteLine($"Количество символов: {str.Length},количество пробелов: {count_s}, количество гласных букв: {count_v}");


//Задание 6
// Console.Write("Введите слово: ");
// string word = Console.ReadLine().ToLower();

// string new_word = "";
// for (int i = word.Length - 1; i >= 0; i--)
// {
//     new_word += word[i];
// }

// if (new_word.Contains(word))
// {
//     Console.WriteLine("Слово палиндром");
// }
// else
// {
//     Console.WriteLine("Слово не палиндром");
// }

//Проверка email
Console.Write("Введите email: ");
string email = Console.ReadLine().ToLower();
int count_d = 0;
foreach (char c in email)
{
    if (c == '@')
    {
        count_d++;
    }
}
if (email.Length >= 5)
{
    if (count_d == 1)
    {
        if (!email.StartsWith('@') && !email.EndsWith('@'))
        {
            if (!email.Contains(' '))
            {
                if (email.EndsWith(".ru") || email.EndsWith(".com"))
                {
                    Console.WriteLine($"Адрес корректен! {email}");
                }
                else
                {
                    Console.WriteLine("Адрес некорректен. Адрес не заканчивается на .ru или .com");
                }
            }
            else
            {
                Console.WriteLine("Адрес некорректен. В адресе есть пробелы");
            }
        }
        else
        {
            Console.WriteLine("Адрес некорректен. Адрес начинается или заканчивается на @");
        }
    }
    else
    {
        Console.WriteLine($"Адрес некорректен. Количество @: {count_d}");
    }
}
else
{
    Console.WriteLine("Адрес некорректен. Длина не меньше 5 символов");
}