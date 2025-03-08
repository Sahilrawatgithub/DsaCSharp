namespace DSA_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 6, 8, 11, 13, 14 };
            int key = 6;    

            BinarySearch.Search(arr, key);
        }

        void Print(int[] arr)
        {
            for(int i=0;i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
