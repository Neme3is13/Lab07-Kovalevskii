// задание 1.1
// string[] days = { "пн", "вт", "ср", "чт", "пт", "сб", "вс",};

// for (int i = days.Length -1; i >= 0; i--)
// {
//     System.Console.WriteLine($"{i}: {days[i]}");
// }
// zadanie 1.2
// double[] temp = {-2.4, 5.3, 4.0, 5.2, -6.6, 4.4, 6.7};
// foreach (double t in temp)
// {
//     System.Console.Write($"{t} ");
// }
// zadanie 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int total = 0;
// foreach (int pr in prices)
// {
//     sum += pr;
//     if (pr > 100)
//     {
//         total++;
//     }
// }
// double average = (double)sum / prices.Length;
// System.Console.WriteLine($"sum {sum}, dorozhe_100 {total}");
// zadanie 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int index = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//     if (max < prices[i])
//     {
//         max = prices[i];
//         index = i;
//     }
// }
// System.Console.WriteLine($"min element = {min}, max index = {index}");
//zadanie 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
//     System.Console.Write($"{balance[i]} ");
// }
//zadanie 5
// int[] numbers = new int[5];
// int chet = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"введите число {i + 1}: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write($"{numbers[i]} ");
// }
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         chet++;
//     }
// }
// System.Console.WriteLine($"количество чётных чисел: {chet}");
//zadanie 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// int index = -1;
// Console.Write("введите имя: ");
// string name = Console.ReadLine();
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == name)
//     {
//         index = i;
//         break;
//     }
//     else
//     {
        
//     }
// }
// if (index != -1)
// {
//     System.Console.WriteLine($"{name} na pozicii {index}");
// }
// else
// {
//     System.Console.WriteLine("не найдено");
// }
// last zadacha
int[] grades = new int[8];
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Оценка {i + 1}: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Оценки: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"{grades[i]} ");
}
Console.WriteLine();
int sum = 0;
for (int i = 0; i < grades.Length; i++)
{
    sum += grades[i];
}
double average = (double)sum / grades.Length;
Console.WriteLine($"Средняя: {average:F2}");
int max = grades[0];
int min = grades[0];
for (int i = 1; i < grades.Length; i++)
{
    if (grades[i] > max)
    {
        max = grades[i];
    }
    if (grades[i] < min)
    {
        min = grades[i];
    }
}
Console.WriteLine($"Макс: {max}");
Console.WriteLine($"Мин: {min}");
int twos = 0;
int fives = 0;
for (int i = 0; i < grades.Length; i++)
{
    if (grades[i] == 2)
    {
        twos++;
    }
    if (grades[i] == 5)
    {
        fives++;
    }
}
Console.WriteLine($"Двоек: {twos}");
Console.WriteLine($"Пятёрок: {fives}");
if (average >= 4.5)
{
    Console.WriteLine("Отличник");
}
else if (average >= 3.5)
{
    Console.WriteLine("Хорошист");
}
else
{
    Console.WriteLine("Есть над чем поработать");
}