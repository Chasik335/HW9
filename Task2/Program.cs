// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ValueInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int SumRec(int number1, int number2)
{
 if (number2 == number1 - 1) return 0;
 else return number2 + SumRec(number1, number2 - 1);
}
int numberStart = ValueInput();
int numberEnd = ValueInput();
Console.WriteLine($"Сумма чисел от {numberStart} до {numberEnd} равна {resalt} ");

