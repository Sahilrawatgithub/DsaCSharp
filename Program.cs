namespace DSA_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I have many array problems, please adhere to following instructions for a smooth experience.");
            Console.WriteLine("Press 1 if you want to Put zeroes at end");
            Console.WriteLine("Press 2 if you want to find Maximum Subarray");
            Console.WriteLine("Press 3 if you want to Rotate array by k elements");
            Console.WriteLine("Press 4 if you want to find intersection of 2 arrays");
            Console.WriteLine("Press 5 if you want to find majority element");
            
            Console.WriteLine("Press 6 if you want to exit");
            Console.WriteLine("\n");

            bool Flag = true;
            while (Flag)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        MoveZeroes moveZeroes = new MoveZeroes();
                        moveZeroes.Start();
                        Console.WriteLine("\n");
                        Console.WriteLine("Please follow instructions given above");
                        break;

                    case "2":
                        MaximumSubarray maximumSubarray = new MaximumSubarray();
                        maximumSubarray.Start();
                        Console.WriteLine("\n");
                        Console.WriteLine("Please follow instructions given above");
                        break;

                    case "3":
                        RotateArray rotateArray = new RotateArray();
                        rotateArray.Start();
                        Console.WriteLine("\n");
                        Console.WriteLine("Please follow instructions given above");
                        break;

                    case "4":
                        Intersection intersection = new Intersection();
                        intersection.Start();
                        Console.WriteLine("\n");
                        Console.WriteLine("Please follow instructions given above");
                        break;

                    case "5":
                        MajorityElement major = new MajorityElement();
                        major.Start();
                        Console.WriteLine("\n");
                        Console.WriteLine("Please follow instructions given above");
                        break;

                    case "6":
                        Console.WriteLine("Exiting");
                        Flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input, please follow instructions.");
                        break;
                }
            }
        }
    }
}
