// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 3 == 0)
Console.WriteLine("Число кратно трем! "+ n);
else 
Console.WriteLine("Число не кратно трем (остаток: " + n % 3+" )");


 
