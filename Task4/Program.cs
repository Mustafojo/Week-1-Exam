int SumOfDigits(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
        cnt += i%10;
    }
    return cnt;
}

System.Console.Write("The sum of the digits of the number 1234 is : ");
System.Console.WriteLine(SumOfDigits(1234));