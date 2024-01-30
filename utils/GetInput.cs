namespace app
{
    public static class Helpers
    {
        public static T GetInput<T>(string prompt)
        {
            Console.WriteLine($"Enter: {prompt}");
            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    return (T)Convert.ChangeType(input, typeof(T));

                }
                catch (Exception)
                {

                    Console.WriteLine($"Invalid input. Please enter a valid {typeof(T).Name}.");
                }

            }


        }

    }
}