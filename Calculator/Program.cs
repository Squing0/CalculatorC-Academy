internal class Program
{
    private static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while(!double.TryParse(numInput1, out cleanNum1))
            {

            }
        }
    }
}