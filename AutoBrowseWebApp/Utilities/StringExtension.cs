namespace AutoBrowseWebApp.Utilities
{
    public static class StringExtension
    {
        public static int ToInt(this string str)
        {
            return string.IsNullOrEmpty(str) ? 0 : int.Parse(str);
        }
    }
}
