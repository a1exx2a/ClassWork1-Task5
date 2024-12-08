namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {-1,1,-2,2,-3,3,-4,4};
        int t = 0;
        foreach (int i in x) {
            if (i < 0) {
                t = t+i;
            }
        }
        Console.WriteLine(t);
    }
}
