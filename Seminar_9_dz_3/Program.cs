// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M:");
int M= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N= Convert.ToInt32(Console.ReadLine());

int Function (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Function(M - 1, 1);
    if (M > 0 && N > 0) return Function(M - 1, Function(M, N - 1));
return Function(M, N);
}
Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {Function(M, N)}");
