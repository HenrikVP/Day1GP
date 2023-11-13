namespace Day1GP
{
    internal class Program
    {
        static string? str = "Hello World and Beyond";
        // Refactoring commenting of original code, makes it easier to reverse.
        //static string? str = "Hello World and Beyond";

        static void Main(string[] args)
        {
            // Console is a class, WriteLine is a method, str is a field used as a parameter.
            Console.WriteLine(str);
            
            // Making a local variable to store the input from GetInput method.
            string? name2 = GetInput("Enter thy name: ");
            Console.WriteLine("Hello " + name2 + ", and welcome thee to our kingdom.");

        }

        /// <summary>
        /// Lets user input a nullable string and returns it
        /// </summary>
        /// <returns>string</returns>
        static string? GetInput(string query)
        {
            Console.Write(query);
            return Console.ReadLine();
        }


        //Pseudo Code. Explains what to do in "normal" language
    }
}