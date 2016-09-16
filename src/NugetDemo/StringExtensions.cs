namespace NugetDemo
{
    public static class StringExtensions
    {
        public static string Truncate(this string source, int maxLength)
        {
            if (source == null)
                return null;

            if (source.Length > maxLength)
                return source.Substring(0, maxLength);

            return source;
        }
    }
}
