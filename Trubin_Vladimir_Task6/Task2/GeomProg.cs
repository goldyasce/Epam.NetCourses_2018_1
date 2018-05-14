using System;
using DemoApplication;


namespace Task2
{
    class GeomProg : ISeries
    {
        private double firstElement;
        private double denominator;
        private double current;

        public GeomProg(double firstElement, double denominator)
        {
            if (firstElement == 0 || denominator == 0)
            {
                throw new Exception("Первый член прогрессии и знаменатель должны быть не нулевыми!");
            }
            else
            {
                this.firstElement = firstElement;
                this.denominator = denominator;
            }
        }

        public double GetCurrent()
        {
            return current;
        }
        public bool MoveNext()
        {
            current *= denominator;
            return true;
        }
        public void Reset()
        {
            current = denominator;
        }
    }
}

