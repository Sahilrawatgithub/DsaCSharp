namespace DSA_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 7, 4, 9, 5 ,12,123,14,15};

            //BubbleSort.Sort(arr);

            //SelectionSort.Sort(arr);

            //InsertionSort.Sort(arr);


            MergeSort.Divide(arr,0,arr.Length-1);
            
            Display(arr);
        }

        static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }
        }
    }
}
