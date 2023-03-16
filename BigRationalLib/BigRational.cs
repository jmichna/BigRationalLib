using System.Numerics;

namespace BigRationalLib
{
    public readonly struct BigRational
    {
        // dane, wewnętrzna reprezentacja
        public BigInteger Numerator { get; init; }
        public BigInteger Denominator { get; init; }

        public static readonly BigRational Zero = new BigRational(0, 1);
        public static readonly BigRational One = new BigRational(1, 1);
        public static readonly BigRational NaN = new BigRational(0, 0);

        // konstruktory
        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            Numerator = numerator;
            Denominator = denominator;

            if ( this.Equals(NaN) ) return;

            // znaki ułamka
            if (Denominator.Sign == -1)
            {
                Numerator *= -1;
                Denominator *= -1;
            }


            // uproszczeie
            BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);
            if (gcd != 0)
            {
                Denominator /= gcd;
                Numerator /= gcd;
            }

        }

        // ToString

        // rowność

        // realcje

        // arytmetyka

        // konwersja
    }
}