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
                MaxNumber = 100,
                Num1 = 3,
                Num2 = 5,
                Message1 = "Fizz",
                Message2 = "Buzz"
            };
        }

        [Fact]
        public void BuildMessageTest()
        {
            for(var i = 1; i <= TestModel.MaxNumber; i++)
            {
                var result = _fizzBuzzService.GetPhrase(TestModel, i);
                if (i % TestModel.Num1 == 0 && i % TestModel.Num2 == 0)
                {
                    Assert.Equal("FizzBuzz\n", result);
                }
                else if(i % TestModel.Num1 == 0)
                {
                    Assert.Equal("Fizz\n", result);
                }
                else if(i % TestModel.Num2 == 0)
                {
                    Assert.Equal("Buzz\n", result);
                }
                else
                {
                    Assert.Equal(i.ToString() + "\n", result);
                }
                
            }
        }

    }
}
