string NumbersRec(int a, int b)
{
if (a <= b) return NumbersRec(a, b-1) + $"{b} ";
else return String.Empty;
}
Console.WriteLine(NumbersRec(3,9));