namespace Ch03_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] products = new int[5] { 1, 2, 3, 4, 5 };
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            string[] names = new string[5];

            int[,] arr2 = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            int[][] arr = new int[5][];
            arr[0] = new int[10];
        }
    }
}
