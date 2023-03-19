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


//Console.Write("Введите число: ");
//int Value = Convert.ToInt32(Console.ReadLine());
//int Lenght = Value.ToString().Length;
//if (Lenght >= 3)
//{
//    while (Value > 999)
//    {
//        Value = Value / 10;
//    }
//    int result = Value % 10;
//    Console.WriteLine("Третья цифра числа: " +result);
//}
//else
//{
//    Console.WriteLine("Число содержит меньше трёх цифр.");
//}


// Task 15.
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели,и проверяет, является ли этот день выходным.
// Пример:
// 6 -> да.
// 7 -> да.
// 1 -> нет.


Console.Write("Введите день недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7)
{
    if (Day >=6)
    {
        Console.Write("Да.");
    }
    else
    {
        Console.Write("Нет.");
    }
}
else
{
    Console.Write("Введите действительный день между 1 и 7.");
}