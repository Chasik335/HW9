// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int ValueInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
double FunctionAkkermana(double m, double n)
{
  if (m == 0) return n +1;
  else if (m > 0 && n ==0) return FunctionAkkermana(m - 1, 1);
  else return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
}
var m = ValueInput();
var n = ValueInput();
Console.WriteLine($"A({m},{n}) = {FunctionAkkermana(m, n)}");