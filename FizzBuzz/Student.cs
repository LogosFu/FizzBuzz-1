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
            return this.order.ToString();
        }
    }
}