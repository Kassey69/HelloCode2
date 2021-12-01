// 12. Удалить вторую цифру трёхзначного числа
string num = 123.ToString(); 
if (num.Length > 1)
{
 num = num.Remove(num.Length - 2, 1);
 Console.Write(num);
}


