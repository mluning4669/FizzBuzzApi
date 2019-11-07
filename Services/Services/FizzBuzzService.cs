using FizzBuzzApi.Models;
using IServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApi.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string BuildMessage(FizzBuzzModel model)
        {
            var message = "";
            for(var i = 1; i < model.MaxNumber; i++)
            {
                message += GetPhrase(model, i);
            }

            return message;
        }

        private string GetPhrase(FizzBuzzModel m, int i)
        {
            if(i % m.Num1 == 0)
            {
                var phrase = m.Message1;
                if (i % m.Num2 == 0)
                {
                    phrase += m.Message2 + "\n";
                    return phrase;
                }
                else
                {
                    return phrase + "\n";
                }
            }

            if(i % m.Num2 == 0)
            {
                return m.Message2 + "\n";
            }

            return i.ToString() + "\n";
        }
    }
}
