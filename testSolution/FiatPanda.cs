using System;

namespace testSolution
{
    public class FiatPanda : Car
    {
        public FiatPanda() : base("Fiat Panda") { }

        private void ChangeTire()
        {
            Console.WriteLine($"{_model}: Smontaggio gomme consumate");
            Console.WriteLine($"{_model}: Montaggio gomme nuove");
            Console.WriteLine($"{_model}: Controllo pressione");
        }

        public override void Execute()
        {
            AnnualReview();
            ChangeTire();
        }
    }
}
