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
            if (IsMultipleOf(this.order, 3))
            {
                return "Fizz";
            }

            if (IsMultipleOf(this.order, 5))
            {
                return "Buzz";
            }

            if (IsMultipleOf(this.order, 7))
            {
                return "Whizz";
            }

            return this.order.ToString();
        }

        private static bool IsMultipleOf(int intPtr, int multiple)
        {
            return intPtr % multiple == 0;
        }
    }
}