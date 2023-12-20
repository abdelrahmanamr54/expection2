namespace exeption2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                string input =Convert.ToString(Console.ReadLine());
                ContainsVowels(input);
                Console.WriteLine("The input contains vowels.");
            }
            catch (novolwes ex)
            {
                Console.WriteLine(
                    "error"



                    
                    
                    
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:done");
            }

        }

        static bool ContainsVowels(string input)
        {
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}