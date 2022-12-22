/*
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Clear();
if(num1 == Convert.ToInt32(Math.Pow(num2, 2))){
   Console.WriteLine($"Да! Число {num1} является квадратом {num2}!");
}
else{
    Console.WriteLine($"Нет! Число {num1} не является квадратом {num2}!");
}*/

/*
Console.Write("Введите номер дня: ");
int num = int.Parse(Console.ReadLine()!);
Console.Clear();
if(num == 1){
    Console.WriteLine("Понедельник");
}
else if(num == 2){
    Console.WriteLine("Вторник");
}
else if(num == 3){
    Console.WriteLine("Среда");
}
else if(num == 4){
    Console.WriteLine("Четверг");
}
else if(num == 5){
    Console.WriteLine("Пятница");
}
else if(num == 6){
    Console.WriteLine("Суббота");
}
else if(num == 7){
    Console.WriteLine("Воскресенье");
}
else{
    Console.WriteLine("Введите число от 1 до 7!!!");
}*/

/*
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write($"Последняя цифра числа {num}: {num % 10}");*/


// Домашняя работа

// задача 1
/*
Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

    if (num_A > num_B)
    {
        Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
    }
    else
    {
        Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
    }*/

// задача 2
/*
Console.WriteLine("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

    if (num_2 > max)
    {
        max = num_2;
    }

    if (num_3 > max)
    {
        max = num_3;
    }

    Console.WriteLine("Наибольшее из введённых чисел -> " + max);*/

// Задача 3 
/*
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num + " является: ЧЁТНЫМ");
}*/

// Задача 4 
/*
int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 != 1)
 {
    Console.Write(i + ", ");
        not = false;
}
i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}*/
