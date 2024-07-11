namespace two_pointers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var problem = new TrappingRainWaterProblem();
            var water = problem.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            Console.Read();
        }
    }
}
