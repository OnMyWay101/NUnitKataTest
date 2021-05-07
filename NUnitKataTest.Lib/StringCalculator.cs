using System;

namespace NUnitKataTest.Lib
{
    public class StringCalculator
    {
        private const String DefaultDelimiter = ",";
        private const String NewDelimiterPrefix = "//";
        private const String NewDelimiterSuffix = "\n";
        private const String CurrentDelimiter = "";

        public static int Add(string numbers) => IsEmptyOrNull(numbers)
                                                    ? 0
                                                    : GetSum(numbers);

        private static bool IsEmptyOrNull(string s)
        {
            if (s == String.Empty || s == null)
                return true;
            return false;
        }

        private static int GetSum(string numbers)
        {
            //获取分隔符
            //替换'\n'位分隔符
            //分离字符串成各段
            //求各段的值并返回结果
            return 0;
        }

        private static string GetDelimiter(string numbers)
        {

        }
    }
}
