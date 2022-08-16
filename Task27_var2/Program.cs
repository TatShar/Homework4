// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberT = Convert.ToString(number);
int sum = 0;

int length = numberT.Length;
for (int i = 0; i<length; i++) {
sum = sum + numberT[i];
}

Console.Write(sum);

