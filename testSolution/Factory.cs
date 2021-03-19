using System;
using System.Collections.Generic;

namespace testSolution
{
    public class Factory
    {
        public List<Car> ReadJob (IEnumerable<string> jobs)
        {
            var result = new List<Car>();

            foreach( var j in jobs)
                switch (j)
                {
                    case "Fiat 500":
                        result.Add(new Fiat500());
                        break;
                    case "Fiat Panda":
                        result.Add(new FiatPanda());
                        break;
                    case "Fiat Tipo":
                        result.Add(new FiatTipo());
                        break;
                    default:
                        Console.WriteLine($"{j} is not supported");
                        break;
                }
            return result;
        }
    }
}