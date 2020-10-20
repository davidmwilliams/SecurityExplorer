using System;
using System.Globalization;

namespace SecurityExplorer.Helpers
{
    public class CalculationHelper
    {
        private const string Decimal = ".";

        public static int GetDecimalPointPosition(double size)
        {
            string fileSize = $"{$"{Math.Abs(size):F20}".ToString(new CultureInfo("en-US"))}";
            if(fileSize.Contains(Decimal))
            {
                return fileSize.IndexOf(Decimal, StringComparison.Ordinal);
            }

            return fileSize.Length;
        }

        public static int GetPowerForFileSize(double size)
        {
            int power = 0;
            double newSize = size;
            while(GetDecimalPointPosition(newSize) > 3 && power < 5)
            {
                newSize = size / Math.Pow(1024.0, ++power);

                if(Math.Truncate(newSize) == 0)
                {
                    return power > 0 ? --power : power;
                }
            }

            return power;
        }

        public static string GetFormatterFileSize(double size)
        {
            int power = GetPowerForFileSize(size);

            size /= Math.Pow(1024.0, power);
            size = Math.Round(size, 2);

            switch(power)
            {
                case 0:
                    return $"{size} B";
                case 1:
                    return $"{size} KB";
                case 2:
                    return $"{size} MB";
                case 3:
                    return $"{size} GB";
                case 4:
                    return $"{size} TB";
                default:
                    throw new ArgumentException(nameof(power));
            }
        }
    }
}