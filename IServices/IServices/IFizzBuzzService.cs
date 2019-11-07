using FizzBuzzApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.IServices
{
    public interface IFizzBuzzService
    {
        string BuildMessage(FizzBuzzModel model);
    }
}
