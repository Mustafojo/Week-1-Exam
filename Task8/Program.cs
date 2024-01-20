string TEXT(string txt, int n)
{
    if(n == 1) return txt;
    else
    {
        return txt + TEXT(txt , n-1);
    }
}

string txt = Console.ReadLine();
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(TEXT(txt,n));