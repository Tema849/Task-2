// Task 10.
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Пример.
// 456 -> 5.
// 782 -> 8.
// 918 -> 1/


//Console.WriteLine("Введите трёхзначное число: ");
//int Value = Convert.ToInt32(Console.ReadLine());
///int Length = Value.ToString().Length;
//if(Length == 3)
//{
//    int result = (Value / 10) % 10;
//    Console.WriteLine("Вторая цифра; " +result);
//}
//else
//{
//    Console.WriteLine("Нет трёхзначного числа.");
//}



// Task 13.
// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// Пример:
// 645 -> 5.
// 78 -> третьей цифры нет.
// 32679 -> 6.


Console.Write("Введите число: ");
int Value = Convert.ToInt32(Console.ReadLine());
int Lenght = Value.ToString().Length;
if (Lenght >= 3)
{
    while (Value > 999)
    {
        Value = Value / 10;
    }
    int result = Value % 10;
    Console.WriteLine("Третья цифра числа: " +result);
}
else
{
    Console.WriteLine("Число содержит меньше трёх цифр.");
}