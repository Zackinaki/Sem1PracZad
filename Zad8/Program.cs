Console.Clear();
Console.Write("Vvedite chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
int i =1;
while (n<1)
{
    Console.Write("Vvdedite chislo ot 1: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Chetnii chisla ot 1 do {n}: ");
if(n==1)
    {
        Console.Write("netu");
    }
while(i<=n)
{
    
    if(i%2==0)
    {
        Console.Write(i +" ");
        i++;
    }
    else
    i++;
}