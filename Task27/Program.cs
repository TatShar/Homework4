// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Input a number A: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
int ostatok;

while(number !=0){

ostatok = number%10;
sum= sum + ostatok;
number=number/10;
}

Console.Write(sum);