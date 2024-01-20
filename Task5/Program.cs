
int b = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[b];

for (int i = 0; i < b; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    arr[i] += a;
    System.Console.WriteLine(arr[i] + " ");
   
}



