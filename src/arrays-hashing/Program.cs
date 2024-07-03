using arrays_hashing;

internal class Program
{
    private static void Main(string[] args)
    {
        var problem = new LongestConsecutiveSequenceProblem();
        var l = problem.LongestConsecutive(new int[] { 0, 3, 2, 5, 4, 6, 1, 1 });
        Console.WriteLine(l);
        Console.Read();
    }
}