using arrays_hashing;

internal class Program
{
    private static void Main(string[] args)
    {
        var validAnagram = new ValidAnagramProblem();
        validAnagram.IsAnagram("bbcc", "ccbc");
    }
}