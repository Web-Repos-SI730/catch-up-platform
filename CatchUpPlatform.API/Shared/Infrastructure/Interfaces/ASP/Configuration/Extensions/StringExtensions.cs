using System.Text.RegularExpressions;

namespace CatchUpPlatform.API.Shared.Infrastructure.Interfaces.ASP.Configuration.Extensions;

public static partial class StringExtensions
{
    public static string ToKebabCase(this string text)
    {
        if(string.IsNullOrEmpty(text))
         return text;
        
        return KebabCaseRegex().Replace(text, "-$1")
            .Trim()
            .ToLower();
    }
    [GeneratedRegex("[a-z0-9]+(?:-[a-z0-9]+)*")]
    private static partial Regex KebabCaseRegex();
}