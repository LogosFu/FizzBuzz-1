using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Test1()
        {
            Class1 class1 = new Class1();

            //then
            Assert.NotNull(class1);
        }
    }

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
    }
}