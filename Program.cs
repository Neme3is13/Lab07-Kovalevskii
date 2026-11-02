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
using System.Xml;

string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
int index = -1;
Console.Write("введите имя: ");
string name = Console.ReadLine();
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == name)
    {
        index = i;
        break;
    }
    else
    {
        
    }
}
if (index != -1)
{
    System.Console.WriteLine($"{name} na pozicii {index}");
}
else
{
    System.Console.WriteLine("не найдено");
}