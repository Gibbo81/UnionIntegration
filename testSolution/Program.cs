using System;
using System.Collections.Generic;

namespace testSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var works = new List<string> { "Fiat 500", "Fiat Panda", "Fiat 500", "Fiat Tipo" };

            var f = new Factory();
            var list = f.ReadJob(works);
            list.ForEach(x => x.Execute());

            Console.ReadLine();
        }
    }
}