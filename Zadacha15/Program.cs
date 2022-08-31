// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите число от 1 до 7: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

void DNedel(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.WriteLine("Это выходной день");
        }
        else
        {
            Console.WriteLine("Это рабочий день");
        }
    }
    else
    {
        Console.WriteLine("Невозможно определить, какой день");
    }
    
}
DNedel(DayNumber);