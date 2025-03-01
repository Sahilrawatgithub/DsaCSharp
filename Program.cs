namespace DSA_core
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I have many string problems, please adhere to following instructions for a smooth experience.");
            Console.WriteLine("Press 1 if you want to CheckPalindrome");
            Console.WriteLine("Press 2 if you want to CheckAnagram");
            Console.WriteLine("Press 3 if you want to implement string compression");
            Console.WriteLine("Press 6 if you want to exit");
            Console.WriteLine("\n");

            bool Flag = true;
            while (Flag)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        CheckPalindrome palindrome = new CheckPalindrome();
                        palindrome.start();
                        break;

                    case "2":
                        CheckAnagram checkAnagram = new CheckAnagram();
                        checkAnagram.start();
                        break;

                    case "3":
                        StringCompression stringCompression = new StringCompression();
                        stringCompression.Start();
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
