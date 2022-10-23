// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления). 
// Например: 14212 -> нет, 12821 -> да, 23432 -> да


int BackNum5 (int n)
{
    int a1 = n / 10000;
    int a5 = n % 10;
    int a2 = (n / 1000) % 10;
    int a4 = (n % 100) / 10;
    int a3 = (n / 100) % 10;
    int a = a1;
    a1 = a5;
    a5 = a;
    a = a2;
    a2 = a4;
    a4 = a;
    int res = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
    return res;
}

Console.WriteLine("Введиет целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999) 
{
     Console.WriteLine("Вы ввели не пятизначное число, введите корректные данные");
}
else
{
    int backnumber = BackNum5(number);
    //Console.WriteLine(backnumber);
    string result = number == backnumber? $"{number}  ->  Да" : $"{number}  ->  Нет";
    Console.WriteLine(result);
}
