using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzApi.Models
{
    public class FizzBuzzModel
    {
        [Range(1,1000)]
        public int MaxNumber { get; set; }
        [Range(1, 100)]
        public int Num1 { get; set; }
        [Range(1, 100)]
        public int Num2 { get; set; }
        [Required]
        public string Message1 { get; set; }
        [Required]
        public string Message2 { get; set; }
    }
}
