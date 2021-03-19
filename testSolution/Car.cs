using System;

namespace testSolution
{
    public abstract class Car
    {
        protected string _model;

        protected Car(string model)
        {
            _model = model;
        }

        protected void AnnualReview()
        {
            Console.WriteLine($"{_model}: Controllo pressione gomme");
            Console.WriteLine($"{_model}: Controllo olio");
            Console.WriteLine($"{_model}: Controllo luci");
        }

        public abstract void Execute();
    }
}
