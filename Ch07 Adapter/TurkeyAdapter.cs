using System;

namespace Ch7_Adapter
{
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            //Turkeys fly in short spurts, so 5 turkey flights = 1 duck flight.
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
