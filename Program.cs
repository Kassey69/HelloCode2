﻿//23. Показать таблицу квадратов чисел от 1 до N 
Console.Write("Введите кол-во чисел для вывода:");
 int N = int.Parse(Console.ReadLine());
 
 Console.WriteLine("Число" + "\t" + "Квадрат");
 for(int i = 1; i <= N; i++)
 Console.WriteLine(i + "\t" + i*i);
 
Console.ReadLine();
  
