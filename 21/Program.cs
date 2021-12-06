//21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите 5 значное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n.ToString().Length < 5 || n.ToString().Length > 5) 
{ 
  Console.WriteLine("в числе нет 5 цифр");{
  }
  return;
}
int num;
int rev;
int dig;
num = n;
rev = 0;

while(n > 0){
  dig = n % 10;
  rev = rev * 10 + dig;
    n = n / 10;
}
if(num == rev)
    Console.Write("Это палиндром!");   
else
    Console.Write("Это не палиндром!");

     