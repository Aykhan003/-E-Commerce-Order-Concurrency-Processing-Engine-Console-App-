namespace ConsoleApp47.Methods;

public static class StringExtensions
{
    public static string ToCapitalize(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;
        return char.ToUpper(text[0]) + text.Substring(1);
    }
}
