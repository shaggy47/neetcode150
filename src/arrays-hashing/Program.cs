using arrays_hashing;

internal class Program
{
    private static void Main(string[] args)
    {
        var problem = new TwoSumProblem();
        var l = problem.TwoSumOptimised(new int[] { 1, 2, 3, 4 }, 3);
        Console.WriteLine(l);
        Console.Read();
    }
}