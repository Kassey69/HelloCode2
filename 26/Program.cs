//26. Возведите число А в натуральную степень B используя цикл
double a;
double b;
double c;
Console.WriteLine("введите число, которое вы хотите возвести в степень:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ввести степень, в которую хотите возвести число "+a+":");
b = Convert.ToDouble(Console.ReadLine());
c = Math.Pow(a, b);
Console.WriteLine(a+" в степени "+b+" равно "+c+"!");