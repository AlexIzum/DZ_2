// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
int d = 0;
if (num > 99){
    while (num >= 1000){
        num /= 10;
    }
    if (num >=100 && num <=999){
        d = num % 10;
    }
    Console.WriteLine($"{d}");
}
else{
    Console.WriteLine($"Третьей цифры нет!!!");
}
