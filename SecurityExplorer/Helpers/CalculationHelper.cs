using System;
using System.Globalization;

namespace SecurityExplorer.Helpers
{
    public class CalculationHelper
    {
        private const string DecimalSeparator = ".";

        public static int GetDecimalPointPosition(double size)
        {
            string fileSize = Math.Abs(size).ToString("F20", CultureInfo.InvariantCulture);
            if(fileSize.Contains(DecimalSeparator))
            {
                return fileSize.IndexOf(DecimalSeparator, StringComparison.Ordinal);
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

            string formattedSize = size % 1 == 0
                ? size.ToString("F0", CultureInfo.InvariantCulture)
                : size.ToString("F2", CultureInfo.InvariantCulture);

            switch(power)
            {
                case 0:
                    return $"{formattedSize} B";
                case 1:
                    return $"{formattedSize} KB";
                case 2:
                    return $"{formattedSize} MB";
                case 3:
                    return $"{formattedSize} GB";
                case 4:
                    return $"{formattedSize} TB";
                default:
                    throw new ArgumentException(nameof(power));
            }
        }
    }
}