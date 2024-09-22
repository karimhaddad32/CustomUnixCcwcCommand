using System.Text.RegularExpressions;

namespace CustomCcwc
{
    public static partial class TextCleaner
    {
        public static string CleanText(string text)
        {
            return Spaces().Replace(text, " ").Trim();
        }

        [GeneratedRegex(@"\s+")]
        private static partial Regex Spaces
            ();
    }
}
