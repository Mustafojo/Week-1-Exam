string IsPalindrome(int n)
{
    int cnt = 0;

    for (int i = n; i > 0; i/=10)
    {
        cnt = cnt * 10 + i%10;
    }

    if(n == cnt)
    {
        return "YES";
    }
    else
    {
        return "NO";
    }
}


int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(IsPalindrome(a));