using arrays_hashing;

internal class Program
{
    private static void Main(string[] args)
    {
        var validAnagram = new GroupAnagramsProblem();
        validAnagram.GroupAnagrams(new string[] { "act", "pots", "tops", "cat", "stop", "hat" });
    }
}