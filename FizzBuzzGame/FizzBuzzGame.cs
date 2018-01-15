namespace FizzBuzzKata
{
    public class FizzBuzzGame
    {
        public string GetOutput(int value)
        {
            if (value < 1)
            {
                return "";
            }

            var fizzes = Fizzes(value);
            var buzzes = Buzzes(value);

            if (fizzes && buzzes)
            {
                return "FizzBuzz";
            }

            if (fizzes)
            {
                return "Fizz";
            }

            if (buzzes)
            {
                return "Buzz";
            }

            return value.ToString();
        }

        private bool Fizzes(int value)
        {
            return value % 3 == 0;
        }

        private bool Buzzes(int value)
        {
            return value % 5 == 0;
        }
    }
}
