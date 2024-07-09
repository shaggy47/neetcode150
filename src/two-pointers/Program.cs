namespace two_pointers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var problem = new TwoSum2();
            var triplets = problem.TwoSum(new int[] { 1, 3, 4, 5, 7, 11 }, 9);
            Console.Read();
        }
    }
}
