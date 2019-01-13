using System;
using System.Security.Cryptography;

namespace Game
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _genetaor = new RNGCryptoServiceProvider();

        public static int NumberBetween(int min, int max)
        {
            byte[] randomNumber = new byte[1];

            _genetaor.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Math.Max, and substracting 0.00000000001,
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding done with Math.Floor
            int range = max - min + 1;

            double randomValInRange = Math.Floor(multiplier * range);

            return (int)(min + randomValInRange);
        }
    }
}
