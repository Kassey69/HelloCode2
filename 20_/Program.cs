//20. Задать номер четверти, показать диапазоны для возможных координат
int x=0;int y=0; 
Console.WriteLine("Введите число х от -10 до 10");
while (!int.TryParse(Console.ReadLine(), out x) || x < -10 || x > 10)
{
Console.WriteLine("Ошибка, недопустимое значение. Попробуйте ещё раз.");
}
Console.WriteLine("Введите число y от -10 до 10");
while (!int.TryParse(Console.ReadLine(), out y) || y < -10 || y > 10)
{
Console.WriteLine("Ошибка, недопустимое значение. Попробуйте ещё раз.");
}
 if ((x == 0) && (y == 0)) {
        Console.Write ("Точка по условию не может иметь такое значение ");
        return; // мы останавливаем этой командой процесс, если не поставить то все координаты покажет дальше
         }
    if ((x >= 0) && (y >= 0)){
        Console.Write("Точка в первой координатной четверти, ");       
int min = 0;
int max = 10;
int index = min;
Console.Write("Диапазон возможных координат: ");
while(index <= max)
{
    Console.Write(index);
    Console.Write(",");
    index++;
}
}
    if ((x <= 0) && (y >= 0)){
    Console.Write("Точка во второй координатной четверти, ");
int min = -10;
int max = 10;
int index = min;
Console.Write("Диапазон возможных координат: ");
while(index <= max)
{
    Console.Write(index);
    Console.Write(",");
    index++;
}
}
    if ((x <= 0) && (y <= 0)){
         Console.Write("Точка в третьей координатной четверти, ");

int min = -10;
int max = 0;
int index = min;
Console.Write("Диапазон возможных координат: ");
while(index <= max)
{
    Console.Write(index);
    Console.Write(",");
    index++;
}
}
    if ((x >= 0) && (y <= 0)){
        Console.Write("Точка в четвертой координатной четверти, ");
int min = -10;
int max = 10;
int index = min;
Console.Write("Диапазон возможных координат: ");
while(index <= max)
{
    Console.Write(index);
    Console.Write(",");
    index++;
}
}

