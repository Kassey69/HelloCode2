//17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите 1 число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a / b == b) {
    Console.WriteLine("Первое число является квардатом второго" );
}
else
   if (b / a == a){
       Console.WriteLine("Второе число является квардатом первого" );
   }
   else {
   Console.WriteLine("нет квадрата числа"); 
}

