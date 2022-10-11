namespace FizzBuzz
{
    public class Student
    {
        private int order;

        public Student(int order)
        {
            this.order = order;
        }

        public string SoundOff()
        {
            if (IsMultipleOf(3) && IsMultipleOf(5) && IsMultipleOf(7))
            {
                return "FizzBuzzWhizz";
            }

            if (IsMultipleOf(5) && IsMultipleOf(7))
            {
                return "BuzzWhizz";
            }

            if (IsMultipleOf(3) && IsMultipleOf(7))
            {
                return "FizzWhizz";
            }

            if (IsMultipleOf(3) && IsMultipleOf(5))
            {
                return "FizzBuzz";
            }

            if (IsMultipleOf(3))
            {
                return "Fizz";
            }

            if (IsMultipleOf(5))
            {
                return "Buzz";
            }

            if (IsMultipleOf(7))
            {
                return "Whizz";
            }

            return this.order.ToString();
        }

        private bool IsMultipleOf(int multiple)
        {
            return this.order % multiple == 0;
        }
    }
}