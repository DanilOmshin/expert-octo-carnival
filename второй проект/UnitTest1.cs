using System;
using Xunit;
using rating;

namespace TestRating
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string Tstr = "3 4 5 2 3 4 4 4 4";
            int TN = 9;
            string expected = "Двоек - 1\nТроек - 2\nЧетверок - 5\nПятерок - 1";
            num_rat num_Rat = new num_rat();
            string actual = num_Rat.read_string(Tstr, TN);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            string Tstr = "3 4 55 2 3 4 4 4 4";
            int TN = 9;
            string expected = "Ошибка! Неверный формат чисел (разряды)!";
            num_rat num_Rat = new num_rat();
            string actual = num_Rat.read_string(Tstr, TN);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            string Tstr = "3 4 7 2 3 4 4 4 4";
            int TN = 9;
            string expected = "Ошибка! Неверный формат оценок (значение)! ";
            num_rat num_Rat = new num_rat();
            string actual = num_Rat.read_string(Tstr, TN);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test4()
        {
            string Tstr = "3 4 2 2 3 4 4 4 4";
            int TN = 10;
            string expected = "Ошибка! Неверное количество оценок!";
            num_rat num_Rat = new num_rat();
            string actual = num_Rat.read_string(Tstr, TN);
            Assert.Equal(expected, actual);
        }
    }
}
