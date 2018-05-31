using System.Text.RegularExpressions;

namespace Intellisense
{
    public static class StringExtensions
    {
        public static string[] SplitCamelCase(this string source) => Regex.Split(source, @"(?<!^)(?=[A-Z])");
    }
}