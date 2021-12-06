//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());; //компьютер запоминает введенное наше число
if ((number == 6) || (number == 7)) {
    Console.WriteLine("Выходной");
}
else {
    Console.WriteLine("Не выходной");
}









