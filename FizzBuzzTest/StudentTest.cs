using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class StudentTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Given_student_has_order_when_sound_off_then_return_order(int order)
        {
            //given
            var student = new Student(order);
            //when
            var soundOff = student.SoundOff();
            //then
            Assert.Equal(order.ToString(), soundOff);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void Given_student_order_is_multiple_of_3_when_sound_off_then_return_Fizz(int order)
        {
            //given
            var student = new Student(order);
            //when
            var soundOff = student.SoundOff();
            //then
            Assert.Equal("Fizz", soundOff);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Given_student_order_is_multiple_of_5_when_sound_off_then_return_Buzz(int order)
        {
            //given
            var student = new Student(order);
            //when
            var soundOff = student.SoundOff();
            //then
            Assert.Equal("Buzz", soundOff);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        public void Given_student_order_is_multiple_of_7_when_sound_off_then_return_Whizz(int order)
        {
            //given
            var student = new Student(order);
            //when
            var soundOff = student.SoundOff();
            //then
            Assert.Equal("Whizz", soundOff);
        }
    }
}