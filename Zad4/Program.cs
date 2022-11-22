Console.Clear();
Console.Write("Vvedite chislo pervoe: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite chislo vtoroe: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite chislo tret'e: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(max>b)
max=a;
else
max=b;
if(max>c)
{
Console.Write("max chislo ");
Console.Write(max);
}
else
{
max=c;
Console.Write("max chislo ");
Console.Write(max);
}