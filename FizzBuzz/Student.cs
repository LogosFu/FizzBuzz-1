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
            if (!IsMultipleOf(3) && !IsMultipleOf(5) && !IsMultipleOf(7))
            {
                return this.order.ToString();
            }

            var result = string.Empty;

            if (IsMultipleOf(3))
            {
                result += "Fizz";
            }

            if (IsMultipleOf(5))
            {
                result += "Buzz";
            }

            if (IsMultipleOf(7))
            {
                result += "Whizz";
            }

            return result;
        }

        private bool IsMultipleOf(int multiple)
        {
            return this.order % multiple == 0;
        }
    }
}