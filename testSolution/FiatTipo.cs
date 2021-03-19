using System;

namespace testSolution
{
    public class FiatTipo : Car
    {
        public FiatTipo() : base("Fiat Tipo") {}

        private void ChangeTire()
        {
            Console.WriteLine($"{_model}: Smontaggio gomme consumate ");
            Console.WriteLine($"{_model}: Montaggio gomme nuove ");
        }

        private void EngineOverhaul()
        {
            Console.WriteLine($"{_model}: Smontaggio motore ");
            Console.WriteLine($"{_model}: Sostituzione filtro dell’olio ");
            Console.WriteLine($"{_model}: Rimontaggio motore");
        }


        public override void Execute()
        {
            AnnualReview();
            ChangeTire();
            EngineOverhaul();
        }
    }
}
