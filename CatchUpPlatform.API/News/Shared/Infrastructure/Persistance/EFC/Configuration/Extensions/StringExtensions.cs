namespace CatchUpPlatform.API.News.Shared.Infrastructure.Persistance.EFC.Configuration.Extensions;

public static class StringExtensions
{
    //Este parametro this solo se puede usar en clases estaticas
    public static string ToSnakeCase(this string text)
    {
        static IEnumerator<char> Convert(CharEnumerator e)
        {
            if(!e.MoveNext()) yield break;
            yield return char.ToLower(e.Current);
            
            while(e.MoveNext())
                if (char.IsUpper(e.Current))
                {
                    yield return '_';
                    yield return char.ToLower(e.Current);
                }
                else
                {
                    yield return e.Current;
                }
        }

        return text;
    }
}