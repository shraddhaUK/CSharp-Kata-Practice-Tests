using System;
using Xunit;
using PracticeSample;

namespace PracticeSampleTests
{
    public class UnitTest1
    {
        [Fact]
        public void isStringEmpty()
        {
            string s ="";
            int i = Class1.Add(s);
           Assert.Equal(0,i);
        }

        [Fact]
        public void StringLenIsOne()
        {
            string s ="1";
            int i = Class1.Add(s);
           Assert.Equal(1,i);
        }

        [Fact]
        public void StringLenIsTwo()
        {
            string s ="1,2";
            int i = Class1.Add(s);
           Assert.Equal(3,i);
        }

         [Fact]
        public void StringLenIsN()
        {
            string s ="1,2,3,4,5,6,7,8,9,10";
            int i = Class1.Add(s);
           Assert.Equal(55,i);
        }

        [Fact]
        public void StringWithNewLine()
        {
            string s ="1\n2,3";
            int i = Class1.Add(s);
           Assert.Equal(6,i);
        }

         [Fact]
        public void SupportDelimiter()
        {
            string s ="//;\n1;2";
            int i = Class1.Add(s);
           Assert.Equal(3,i);
        }

         [Fact]
        public void checkNegativeNumber()
        {
            string s ="-1,1,2,-2";
            int i = Class1.Add(s);
           Assert.Equal(3,i);
        }
    }
}
