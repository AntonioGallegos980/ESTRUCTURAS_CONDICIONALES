// See https://aka.ms/new-console-template for more information
Console.WriteLine("Coloque su consumo total");
int consu = int.Parse(Console.ReadLine());
double descu, descu1;
if (consu <=100)
{
    descu = consu - (consu * 0.10);
    descu1 = descu + (descu * 0.18);
    Console.WriteLine("su monto a pgar es de :"+ descu1);
}
if (consu>100)
{
    descu = consu - (consu * 0.20);
    descu1 = descu + (descu * 0.18);
    Console.WriteLine("su monto a pgar es de :" + descu1);
}