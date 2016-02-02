using System.Text;

namespace HtmlParserSharp.Core
{
    internal static class StringBuilderExtensionMethods
    {
        internal static void Clear(this StringBuilder builder)
        {
            builder.Length = 0;
        }
    }
}
