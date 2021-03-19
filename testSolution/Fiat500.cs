using System;

namespace testSolution
{
    public class Fiat500 : Car
    {
        public Fiat500() : base("Fiat 500") { }

        private void EngineOverhaul()
        {
            Console.WriteLine($"{_model}: Smontaggio motore ");
            Console.WriteLine($"{_model}: Sostituzione cinghia trasmissione");
            Console.WriteLine($"{_model}: Rimontaggio motore");
        }

        public override void Execute()
        {
            AnnualReview();
            EngineOverhaul();
        }
    }
}
