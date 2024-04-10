Console.WriteLine("Введите массив строк через запятую :");
string stroka = Console.ReadLine()!;
string [] mass = stroka.Split(',');
var newmass = new string [mass.Length];
int index = 0;
