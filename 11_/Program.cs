// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// ДОпустим это число 68. Наибольшая цифра 8 в этом числе. Ее и надо вывести на экран
int numberA = new Random().Next(10, 99);
Console.WriteLine(numberA);//68
int b;
int c;
        b = numberA / 10;
        c = numberA % 10;
        if (b == c)
            Console.WriteLine("нет наибольшей цифы числа"); 
            else
            if (b > c)
            Console.WriteLine("Первая цифра больше - "+ b);  
            else Console.WriteLine("Вторая цифра больше - "+ c);
            
           




