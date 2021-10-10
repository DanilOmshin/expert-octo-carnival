using System;
using Xunit;
using smallest;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_m10_32_3()
        {
            double tA = -10.32;
            double tB = 32.32;
            double tC = 3;
            double expected = -30.96;


            num a= new num();
            double actual = a.Mul(tA, tB, tC);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_0_0_0()
        {
            double tA = 0;
            double tB = 0;
            double tC = 0;
            double expected = 0;


            num a = new num();
            double actual = a.Mul(tA, tB, tC);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_m4_m4_5()
        {
            double tA = -4;
            double tB = -4;
            double tC = 5;
            double expected = 16;


            num a = new num();
            double actual = a.Mul(tA, tB, tC);
            Assert.Equal(expected, actual);
        }
    }
}
