int SumRec(int a, int b)
{
    if (a <= b) return SumRec(a, b - 1) + b;
    else return 0;
}
Console.WriteLine(SumRec(5, 6));