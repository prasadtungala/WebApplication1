using System.Collections.Generic;

namespace WebApplication1.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        List<FizzBuzzResult> ProcessValues(List<string> values);
    }
}
