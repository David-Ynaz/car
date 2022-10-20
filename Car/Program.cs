
Console.WriteLine("Выберите тип покрытия:\n" +
    "1 - Сухой асфальт\n" +
    "2 - Мокрая дорога\n" +
    "3 - Укатанный снег\n" +
    "4 - Обледененная дорога\n");
int choice = int.Parse(Console.ReadLine());


Console.WriteLine("Скорость км.ч:");
int km = int.Parse(Console.ReadLine());
double s;
switch(choice)
{
    case 1:
        s = (1*km^2)/(254*0.7);
        Console.WriteLine(s*100);
        break;
    case 2:
        s = (1*km^2)/(254*0.4);
        Console.WriteLine(s*100);
        break;
    case 3:
        s = (1*km^2)/(254*0.2);
        Console.WriteLine(s*100);
        break;
    case 4:
        s = (1*km^2)/(254*0.1);
        Console.WriteLine(s * 100);
        break;
}
