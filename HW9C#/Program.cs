// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите целое число N больше 0:");
int N = int.Parse(Console.ReadLine()!);
if (N < 1) Console.WriteLine("Вы ввели число 0 или меньше");
else Console.WriteLine(PrintNumbersNto1 (N, 1));


string PrintNumbersNto1 (int start, int end){
    if (start == 1) return start.ToString();
    return (start + " " + PrintNumbersNto1 (start - 1, end));
}