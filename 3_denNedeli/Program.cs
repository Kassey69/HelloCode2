//По заданному номеру дня недели вывести его название
//Console.Write("Введите число: ");
//int num = Convert.ToInt16(Console.ReadLine());
//switch (num)
//{
 //   case 1: Console.WriteLine("Понедельник"); break;
   // case 2: Console.WriteLine("Вторник"); break;
  //  case 3: Console.WriteLine("Среда"); break;
   // case 4: Console.WriteLine("Четверг"); break;
  //  case 5: Console.WriteLine("Пятница"); break;
 //   case 6: Console.WriteLine("Суббота"); break;
 //   case 7: Console.WriteLine("Воскресенье"); break;
  //  default: Console.WriteLine("ERROR"); break;
//}
//Console.ReadKey();
Console.WriteLine("Введите число от 1 до 7 ");
string number = Console.ReadLine(); //компьютер запоминает введенное наше число
int day = Convert.ToInt16(number);
//int day = number;

if (day == 1)
{
 Console.WriteLine("Понедельник");
}
if (day == 2)
{
 Console.WriteLine("вторник");
}
if (day == 3)
{
 Console.WriteLine("Среда");
}
if (day == 4)
{
 Console.WriteLine("Четверг");
}
if (day == 5)
{
 Console.WriteLine("Пятница");
}
if (day == 6)
{
 Console.WriteLine("суббота");
}
if (day == 7)
{
 Console.WriteLine("Всокресенье");
}







