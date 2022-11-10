// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine($"Сколько М чисел хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];
void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int BigNumNol(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count += 1;
    }
    return count;
}
InputNumbers(m);
Console.WriteLine($"Чисел больше 0 -> {BigNumNol(numbers)} ");