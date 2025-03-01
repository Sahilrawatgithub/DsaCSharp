namespace DSA_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I have many array problems, please adhere to following instructions for a smooth experience.");
            Console.WriteLine("Press 1 if you want to Put zeroes at end");
            
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
