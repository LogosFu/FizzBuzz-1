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
            if (this.order % 3 == 0)
            {
                return "Fizz";
            }

            return this.order.ToString();
        }
    }
}