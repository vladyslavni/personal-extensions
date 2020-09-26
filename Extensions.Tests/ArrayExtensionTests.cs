using System;
using Xunit;

namespace Extension.Tests
{
    public class ArrayExtensionTests
    {
        private string[] testArray;

        public ArrayExtensionTests()
        {
            testArray = new string[6] {"1", "2", "3", "4", "5", "6"};
        }

        [Fact]
        public void When_ArrayCutFromOneToThree__Expect_EqualsArray()
        {
            string[] result = testArray.Cut(1, 3);

            Assert.Equal(new string[] {"1", "5", "6"}, result);
        }
        
        [Fact]
        public void When_ArrayCutFromThreeToOne__Expect_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => testArray.Cut(3, 1));
        }

        [Fact]
        public void When_ArrayCutFromZeroToZero__Expect_WithoutFirstArgument()
        {
            string[] result = testArray.Cut(0, 0);

            Assert.Equal(new string[] {"2", "3", "4", "5", "6"}, result);
        }
                
        [Fact]
        public void When_ArrayExpandByTwo__Expect_EqualsArray()
        {
            string[] result = testArray.Expand(2);

            Assert.Equal(new string[] {"1", "2", "3", "4", "5", "6", null, null}, result);
        }
        
        [Fact]
        public void When_ArrayExpandByZero__Expect_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => testArray.Expand(0));
        }

        [Fact]
        public void When_ArrayExpandByNegativeNumber__Expect_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => testArray.Expand(-3));
        }

        [Fact]
        public void When_ArrayFillMethod__Expect_EqualsArray()
        {
            testArray.Fill("H");

            Assert.Equal(new string[] {"H", "H", "H", "H", "H", "H"}, testArray);
        }
        
        [Fact]
        public void When_ArrayForEachMethod__Expect_EqualsArray()
        {
            string result = "";

            testArray.ForEach((s) => result += s);

            Assert.Equal("123456", result);
        }

        [Fact]
        public void When_ArrayInsertArray__Expect_EqualsArray()
        {
            string[] value = new string[] {"2.5", "2.6"};

            string[] result = testArray.Insert(2, value);

            Assert.Equal(new string[] {"1", "2", "2.5", "2.6", "3", "4", "5", "6"}, result);
        }

        [Fact]
        public void When_ArrayInsertOneParam__Expect_ArgumentException()
        {
            string[] result = testArray.Insert(2, "2.5");
            
            Assert.Equal(new string[] {"1", "2", "2.5", "3", "4", "5", "6"}, result);
        }

        [Fact]
        public void When_ArrayInsertTwoParams__Expect_ArgumentException()
        {
            string[] result = testArray.Insert(2, "2.5", "2.6");
            
            Assert.Equal(new string[] {"1", "2", "2.5", "2.6", "3", "4", "5", "6"}, result);
        }

        [Fact]
        public void When_ArrayInsertInNegativePosition__Expect_ArgumentException()
        {
            string[] value = new string[] {"2.5", "2.6"};

            Assert.Throws<ArgumentException>(() => testArray.Insert(-1, value));
        }

        [Fact]
        public void When_ArrayInsertInOutOfArrayPosition__Expect_ArgumentException()
        {
            string[] newArray = new string[] {"2.5", "2.6"};

            Assert.Throws<ArgumentException>(() => testArray.Insert(testArray.Length + 1, newArray));
        }

        [Fact]
        public void When_ArrayIsContainsOne__Expect_True()
        {
            bool result = testArray.IsContains("1");

            Assert.True(result);
        }

        [Fact]
        public void When_ArrayIsContainsZero__Expect_False()
        {
            bool result = testArray.IsContains("0");

            Assert.False(result);
        }

        [Fact]
        public void When_AlphabetArrayIsContainsLowCaseB__Expect_False()
        {
            testArray = new string[] {"a", "B", "c"};

            bool result = testArray.IsContains("b");

            Assert.False(result);
        }

        [Fact]
        public void When_AlphabetArrayIsContainsB__Expect_True()
        {
            testArray = new string[] {"a", "B", "c"};

            bool result = testArray.IsContains("B");

            Assert.True(result);
        }

        [Fact]
        public void When_AlphabetArrayIsContainsIgnoreCaseA__Expect_True()
        {
            testArray = new string[] {"a", "B", "c"};

            bool result = testArray.IsContainsIgnoreCase("A");

            Assert.True(result);
        }

        [Fact]
        public void When_CharArrayIsContainsIgnoreCaseA__Expect_True()
        {
            char[] testCharArray = new char[] {'a', 'B', 'c'};

            bool result = testCharArray.IsContainsIgnoreCase('A');

            Assert.True(result);
        }


        [Fact]
        public void When_ArrayIsEmpty__Expect_False()
        {
            bool result = testArray.IsEmpty();

            Assert.False(result);
        }

        [Fact]
        public void When_EmptyArrayIsEmpty__Expect_True()
        {
            testArray = new string[2];

            bool result = testArray.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void When_ArrayIsNotNull__Expect_True()
        {
            bool result = testArray.IsNotNull();

            Assert.True(result);
        }

        [Fact]
        public void When_NullArrayIsNotNull__Expect_False()
        {
            testArray = null;

            bool result = testArray.IsNotNull();

            Assert.False(result);
        }

        [Fact]
        public void When_ArrayIsNull__Expect_False()
        {
            bool result = testArray.IsNull();

            Assert.False(result);
        }

        [Fact]
        public void When_NullArrayIsNull__Expect_True()
        {
            testArray = null;
         
            bool result = testArray.IsNull();

            Assert.True(result);
        }

        [Fact]
        public void When_ArrayPushTwoParams__Expect_EqualsArray()
        {
            string[] result = testArray.Push("7", "8");

            Assert.Equal(new string[] {"1", "2", "3", "4", "5", "6", "7", "8"}, result);
        }

        public void When_ArrayPushArray__Expect_EqualsArray()
        {
            string[] value = new string[] {"7", "8"};
            
            string[] result = testArray.Push(value);

            Assert.Equal(new string[] {"1", "2", "3", "4", "5", "6", "7", "8"}, result);
        }

        [Fact]
        public void When_ArrayRandom__Expect_RandomResult()
        {
            string result = testArray.Random();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.True(testArray.IsContains(result));
        }

        [Fact]
        public void When_ArrayResizeToThree__Expect_EqualsSmallArray()
        {
            string[] result = testArray.Resize(3);

            Assert.True(result.Length == 3);
            Assert.Equal(new string[] {"1", "2", "3"}, result);
        }

        [Fact]
        public void When_ArrayResizeToSeven__Expect_EqualsBigArray()
        {
            string[] result = testArray.Resize(7);

            Assert.True(result.Length == 7);
            Assert.Equal(new string[] {"1", "2", "3", "4", "5", "6", null}, result);
        }

        [Fact]
        public void When_ArraySliceFromOneToThree__Expect_EqualsArray()
        {
            string[] result = testArray.Slice(1, 3);

            Assert.Equal(new string[] {"2", "3", "4"}, result);
        }

                
        [Fact]
        public void When_ArraySliceFromThreeToOne__Expect_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => testArray.Slice(3, 1));
        }

        [Fact]
        public void When_ArraySliceFromZeroToZero__Expect_WithoutFirstArgument()
        {
            string[] result = testArray.Slice(0, 0);

            Assert.Equal(new string[] {"1"}, result);
        }
    }
}