using System;

namespace KotorTool_2._0.Utils
{
    public class StringFunctions
    {
        public static string TrimAfterDash(string s)
        {
            if (s.IndexOf("-", StringComparison.Ordinal) == -1) return s;
            return s.Substring(0, s.IndexOf("-", StringComparison.Ordinal) - 1);
        }
    }

    public static class StringExtensions
    {
        public static String TrimAfterDash(this String s)
        {
            if (s.IndexOf("-", StringComparison.Ordinal) == -1) return s;
            return s.Substring(0, s.IndexOf("-", StringComparison.Ordinal) - 1);
        }
    }
}