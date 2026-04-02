using System.Linq;
using Markdig.Syntax.Inlines;

namespace DiscordChatExporter.Gui.Utils.Extensions;

internal static class MarkdigExtensions
{
    public static string GetInnerText(this Inline inline) =>
        inline switch
        {
            LiteralInline literal => literal.Content.ToString(),
            ContainerInline container => string.Concat(container.Select(c => c.GetInnerText())),
            _ => string.Empty,
        };
}
