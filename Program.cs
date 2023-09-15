namespace LogicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibanocci fibanocci = new Fibanocci();
            fibanocci.checkFibanocci(5);

            PerfectNumber perfectNumber = new PerfectNumber();
            perfectNumber.checkPerfectNum(14);

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.checkPrime(5);
        }
    }
}
