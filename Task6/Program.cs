void Swap(ref int a, ref int b)
{
    int xoli = 0;

    xoli = b;

    b = a;

    a = xoli;  
}


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Swap(ref a,ref b);

System.Console.Write("x = ");
System.Console.WriteLine(a);
System.Console.Write("y = ");
System.Console.WriteLine(b);