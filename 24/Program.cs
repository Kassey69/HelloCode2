//24. Найти кубы чисел от 1 до N
Console.Write("Введите кол-во чисел для вывода:");
 int N = int.Parse(Console.ReadLine());
 

 for(int i = 1; i <= N; i++)
 {
    Console.WriteLine(i + "^3 = " + i*i*i);
 }

