using FizzBuzzApi.Models;
using FizzBuzzApi.Services;
using System;
using System.Diagnostics;
using Xunit;

namespace XUnitTestFizzBuzz
{
    public class GetPhraseTest
    {
        private readonly FizzBuzzService _fizzBuzzService;
        private readonly FizzBuzzModel TestModel;

        public GetPhraseTest()
        {
            _fizzBuzzService = new FizzBuzzService();
            TestModel = new FizzBuzzModel
            {
                MaxNumber = 150,
                Num1 = 5,
                Num2 = 7,
                Message1 = "Fizz",
                Message2 = "Buzz"
            };
        }

        [Theory]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GetPhraseTestFizz(int value)
        {
            var result = _fizzBuzzService.GetPhrase(TestModel, value);

            Assert.Equal("Fizz\n", result);
        }

        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(14)]
        [InlineData(21)]
        public void GetPhraseTestBuzz(int value)
        {
            var result = _fizzBuzzService.GetPhrase(TestModel, value);

            Assert.Equal("Buzz\n", result);
        }

        [Theory]
        [InlineData(36)]
        [InlineData(35)]
        [InlineData(70)]
        [InlineData(105)]
        public void GetPhraseTestFizzBuzz(int value)
        {
            var result = _fizzBuzzService.GetPhrase(TestModel, value);

            Assert.Equal("FizzBuzz\n", result);
        }
    }
}
