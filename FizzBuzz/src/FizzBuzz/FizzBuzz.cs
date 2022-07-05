namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string CheckInput(int input)
        {
            string outputString = string.Empty;

            if (input % 3 == 0)
                outputString += "Fizz";

            if (input % 5 == 0)
                outputString += "Buzz";

            if (string.IsNullOrEmpty(outputString))
                outputString = input.ToString();

            return outputString;
        }
    }
}