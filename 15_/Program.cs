﻿// 15. Дано число. Проверить кратно ли оно 7 и 23 
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n % 7 == 0) && (n % 23 == 0))
Console.WriteLine("Число кратно 7 и 23  -  "+ n);
else 
Console.WriteLine("Число не кратно 7 и 23  -  "+ n);  // (остаток: " + n % 7+" )");

