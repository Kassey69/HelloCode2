// 14. Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите любое целое число");
int n = Convert.ToInt32(Console.ReadLine());

if (n.ToString().Length < 3)
{ 
  Console.WriteLine("в числе нет 3 цифр");
}
else  
Console.WriteLine(n.ToString()[2]);// в ' ' должно находиться 1 
                                                // любое значение или пустыми оставить
       

