Console.WriteLine("########SOMAR VALORES");


int SomarValores(int v1, int v2)
{
    return v1 + v2;
}
Console.Write("vLAOR 1: ");
int a  =  Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int total = SomarValores(a, b);
Console.Write("Total da soma é " + SomarValores(a, b));
Console.Write("Total da soma  vezes 5 é " + (SomarValores(a, b) * 5));




