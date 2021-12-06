//25. Найти сумму чисел от 1 до А
Console.Write("Введите кол-во чисел для вывода:");
 int A = int.Parse(Console.ReadLine());
 int result = 0;
 for(int i = 1; i <= A; i++)
 {
     result = result + i;
    Console.Write(i);
    if (i != A) Console.Write(" + ");
    }
    Console.Write(" = " + result);
 
