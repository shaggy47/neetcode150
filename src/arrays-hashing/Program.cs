using arrays_hashing;

internal class Program
{
    private static void Main(string[] args)
    {
        var problem = new TopKFrequentElementsProblem();
        problem.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
    }
}