//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число от 1 до 7 ");
string number = Console.ReadLine(); //компьютер запоминает введенное наше число
int day = Convert.ToInt16(number);
if (day == 1){
 Console.WriteLine("Понедельник");}
if (day == 2){
 Console.WriteLine("вторник");}
if (day == 3){
 Console.WriteLine("Среда");}
if (day == 4){
 Console.WriteLine("Четверг");}
if (day == 5){
 Console.WriteLine("Пятница");}
if (day == 6){
 Console.WriteLine("суббота, выходной");}
if (day == 7){
 Console.WriteLine("Воскресенье, выходной");}








