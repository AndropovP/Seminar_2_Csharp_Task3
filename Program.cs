// 3. Напишите программу, которая принимает на вход цифру, обозначающую лень недели, и проверяет 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Функция вводит целое значение из консоли
int ReadInt(string message)
{
    Console.Write(message);                             // Ввод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

bool Validate3sign(int number)
{
    if (number < 1 || number > 7)
    {
        Console.WriteLine("Ведённое число не входит в диапазон, обозначающий дни недели.");
        return false;
    } 
    return true;
}

int digit = ReadInt("Введите число от 1 до 7 > ");
if (Validate3sign(digit))
{
    if (digit >= 1 && digit <=5)
        Console.WriteLine($"Введена цифра {digit} -> не выходной");
    else
        Console.WriteLine($"Введена цифра {digit} -> выходной");
}