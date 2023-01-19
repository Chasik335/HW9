// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int ValueInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void GetNatNumber(int value)
{
    if (value >= 1)
    {
        Console.Write($"|{value}| ");
        GetNatNumber(value -1);
    }

}
int number = ValueInput();
GetNatNumber(number);