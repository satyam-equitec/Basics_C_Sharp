bool isAnagram(int a)
{
    int sum = 0;
    int len = a.ToString().Length;
    int r; int temp = a;
    while (a > 0)
    {
        r = a % 10;
        sum += Convert.ToInt32(Math.Pow(r,len));
        a = a / 10;
    }
    return sum == temp;
}
Console.WriteLine(isAnagram(153));
Console.WriteLine(isAnagram(1634));
