// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// Бесконечный цикл while, который бесконечно принимает строку
// Проверка условия того, что если первый символ строки ==q, то ввод завершается при помощи return
// Если будет выполняться второе условие, которое мы вынесем в другую функцию, возвращающую булевое значение.
// Сумма всех цифр числа будет нечётной, то бесконечный фикл ввода чисел, который должен будет остановиться
int SumDigitsNumber(int number)
{
    int Digit = 0;
    int sum = 0;
    while (number > 0) 
    {
        Digit = number % 10;
        number /= 10;
        sum += Digit;
    }
    return sum;
}

bool IfSummEven(string source)
{
    if (int.TryParse(source, out int number))
    {
        if (SumDigitsNumber(number) % 2 == 0) return true;
        
        return false;
    }
    else 
        return false;
}
 
bool IfExit(string source)
{
    if (source == "q" || IfSummEven(source))
        return true;
    else return false;
}

while (true) 
{
    Console.WriteLine("Введите целое число:");
    string source = Console.ReadLine();
    if (IfExit(source)) 
    {
        Console.WriteLine("[STOP]");
        break;
    }
}
