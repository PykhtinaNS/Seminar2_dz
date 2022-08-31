//  Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int count = chislo.ToString().Length;
if (count < 3 || count > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine("Вторая цифра числа: ");
    Console.WriteLine(Rezult(chislo));
}
int Rezult(int ch)
{
    int cifra = ((ch / 10) % 10);
    return cifra;
}

