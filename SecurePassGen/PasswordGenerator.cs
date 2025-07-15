using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace SecurePassGen
{
    public static class PasswordGenerator
    {
        private const string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Lower = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string DefaultSymbols = "!@#$%^&*()_+-=[]{}|;:',.<>?/";
        private const string SimilarChars = "Il1O0";

        private static readonly Regex SymbolOnlyRegex = new Regex(@"^[!@#$%^&*()_\-+=\[\]{}|;:',.<>?/\\]*$");

        public static string Generate(
            int length,
            bool useUpper,
            bool useLower,
            bool useDigits,
            bool useSymbols,
            bool excludeSimilar,
            bool requireEachType,
            string customSymbols = null
        )
        {
            var pool = "";
            var result = new char[length];
            int index = 0;

            string symbolSet = "";
            string symbolFilteredSet = "";

            if (useSymbols)
            {
                symbolSet = string.IsNullOrEmpty(customSymbols) ? DefaultSymbols : customSymbols;

                if (!string.IsNullOrEmpty(customSymbols) && !SymbolOnlyRegex.IsMatch(customSymbols))
                {
                    throw new ArgumentException("사용자 정의 특수문자에는 특수문자만 입력해야 합니다.");
                }

                symbolFilteredSet = excludeSimilar
                    ? new string(symbolSet.Except(SimilarChars).ToArray())
                    : symbolSet;

                pool += symbolFilteredSet;
            }

            if (useUpper) pool += excludeSimilar ? new string(Upper.Except(SimilarChars).ToArray()) : Upper;
            if (useLower) pool += excludeSimilar ? new string(Lower.Except(SimilarChars).ToArray()) : Lower;
            if (useDigits) pool += excludeSimilar ? new string(Digits.Except(SimilarChars).ToArray()) : Digits;

            if (string.IsNullOrEmpty(pool))
                throw new ArgumentException("사용할 수 있는 문자가 없습니다. 최소 한 가지 문자 유형을 선택하세요.");

            if (requireEachType)
            {
                if (useUpper) result[index++] = GetRandomChar(Upper, excludeSimilar);
                if (useLower) result[index++] = GetRandomChar(Lower, excludeSimilar);
                if (useDigits) result[index++] = GetRandomChar(Digits, excludeSimilar);
                if (useSymbols && !string.IsNullOrEmpty(symbolFilteredSet))
                    result[index++] = GetRandomChar(symbolFilteredSet, false); // excludeSimilar 적용됨
            }

            while (index < length)
                result[index++] = GetRandomChar(pool);

            return Shuffle(result);
        }

        private static char GetRandomChar(string chars, bool excludeSimilar = false)
        {
            if (excludeSimilar)
                chars = new string(chars.Except(SimilarChars).ToArray());

            int index = GetRandomInt(chars.Length);
            return chars[index];
        }

        private static int GetRandomInt(int max)
        {
            if (max <= 0) throw new ArgumentOutOfRangeException(nameof(max));
            byte[] bytes = new byte[4];
            using (var rng = RandomNumberGenerator.Create())
            {
                int value;
                do
                {
                    rng.GetBytes(bytes);
                    value = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
                } while (value >= max * (int.MaxValue / max));
                return value % max;
            }
        }

        private static string Shuffle(char[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = GetRandomInt(i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
            return new string(array);
        }
    }
}
