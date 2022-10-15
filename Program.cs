namespace quotientreaminder213
{
    public static class quotient
    {
        public static void Main(string[] args)
        {
            int dividend = 33, divisor = 3;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("dividend:{0} divisor:{1}", dividend, divisor);
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder = " + remainder);
            Console.ReadLine();
        }
    }
}