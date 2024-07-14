using WebApplication1.Services.Interfaces;
using System.Collections.Generic;

namespace WebApplication1.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<FizzBuzzResult> ProcessValues(List<string> values)
        {
            var results = new List<FizzBuzzResult>();

            foreach (var value in values)
            {
                if (int.TryParse(value, out int number))
                {
                    var result = new FizzBuzzResult { Value = number };

                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        result.Result = "FizzBuzz";
                    }
                    else if (number % 3 == 0)
                    {
                        result.Result = "Fizz";
                    }
                    else if (number % 5 == 0)
                    {
                        result.Result = "Buzz";
                    }
                    else
                    {
                        result.Result = string.Empty;
                        result.Result = "Divided " +number+ " by 3 Divided "+number+" by 5";
                        //result.Logs.Add($"Divided {number} by 3");
                        //result.Logs.Add($"Divided {number} by 5");
                    }

                    results.Add(result);
                }
                else
                {
                    results.Add(new FizzBuzzResult { Value = null, Result = "Invalid Item" });
                }
            }

            return results;
        }
    }

    public class FizzBuzzResult
    {
        public int? Value { get; set; }
        public string Result { get; set; }
        public List<string> Logs { get; set; } = new List<string>();
    }
}
