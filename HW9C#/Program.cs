// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
Console.WriteLine("Введите целое число N больше 0:");
int N = int.Parse(Console.ReadLine()!);
if (N < 1) Console.WriteLine("Вы ввели число 0 или меньше");
else Console.WriteLine(PrintNumbersNto1 (N, 1));


string PrintNumbersNto1 (int start, int end){
    if (start == 1) return start.ToString();
    return (start + " " + PrintNumbersNto1 (start - 1, end));
}
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
Console.WriteLine("Введите целое число M:");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое число N:");
int N = int.Parse(Console.ReadLine()!);

if (M <= N){
Console.WriteLine(SumNumbersMtoN (M, N));
}
else {
Console.WriteLine(SumNumbersMtoN (N, M));
}



int SumNumbersMtoN (int start, int end){
    if (start == end) return start;
        return  start + SumNumbersMtoN (start + 1, end);
}
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите целое число M:");
double M = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите целое число N:");
double N = Convert.ToDouble(Console.ReadLine()!);

if (Akkerman (M, N) == 0){
    Console.WriteLine("Вы ввели не корректные цифры");
}
else {
    Console.WriteLine(Akkerman (M, N));
}
double Akkerman (double m, double n){
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return Akkerman (m - 1, 1);
    if ((m > 0) && (n > 0)) return Akkerman (m - 1, Akkerman(m, n - 1));    
    return 0;
}