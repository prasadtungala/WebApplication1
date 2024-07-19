using WebApplication1.Services.Interfaces;
using System.Collections.Generic;
using WebApplication1.Models;

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
                    result.Result = GetFizzBuzzResult(number);
                    result.Logs = GenerateLogs(number);
                    results.Add(result);
                }
                else
                {
                    results.Add(new FizzBuzzResult { Value = null, Result = "Invalid Item" });
                }
            }

            return results;
        }

        private string GetFizzBuzzResult(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return FizzBuzzType.FizzBuzz.ToString();
            }
            else if (number % 3 == 0)
            {
                return FizzBuzzType.Fizz.ToString();
            }
            else if (number % 5 == 0)
            {
                return FizzBuzzType.Buzz.ToString();
            }
            else
            {
                return $"Divided {number} by 3 Divided {number} by 5";
            }
        }

        private List<string> GenerateLogs(int number)
        {
            var logs = new List<string>();

            if (number % 3 != 0 && number % 5 != 0)
            {
                logs.Add($"Divided {number} by 3");
                logs.Add($"Divided {number} by 5");
            }

            return logs;
        }
    }

    public class FizzBuzzResult
    {
        public int? Value { get; set; }
        public string Result { get; set; }
        public List<string> Logs { get; set; } = new List<string>();
    }

    public enum FizzBuzzType
    {
        FizzBuzz,
        Fizz,
        Buzz
    }
}
