Console.WriteLine("Введите массив строк через запятую :");
Console.WriteLine();
string stroka = Console.ReadLine()!;
string [] mass = stroka.Split(',');
var newmass = new string [mass.Length];
int index = 0;

for (int i = 0; i < mass.Length; i++)
{
    var mass2 = mass[i];
    if (mass2.Length <=3)
    {
       newmass[index] = mass2;
       index++;        
    }

}
