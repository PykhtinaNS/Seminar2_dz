// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int count = chislo.ToString().Length;
if (count < 3)
{
    Console.WriteLine("Третьей цифры в этом числе нет");
}
else
{
    Console.WriteLine("Третья цифра числа: ");
    Console.WriteLine(Rez(chislo, count));
}
int Rez(int a, int k)
{
    int result = 0;
    int b = 1;
    for (int i = k; i > 3; i--)
    {
        b = b * 10;
    }
    result = (a / b) % 10;
    return result;
}


