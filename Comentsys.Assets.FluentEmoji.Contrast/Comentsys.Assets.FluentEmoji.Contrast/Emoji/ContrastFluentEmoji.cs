namespace Comentsys.Assets.FluentEmoji;

/// <summary>
/// Emoji designed by Microsoft. License: MIT License
/// </summary>
public class ContrastFluentEmoji : AssetBase<ContrastFluentEmoji>
{
    private const int width = 32;
    private const int height = 32;
    private const string folder = "Contrast";
    private const string root = "Comentsys.Assets.FluentEmoji.Contrast.Resources";
    private static readonly Color source = Color.FromArgb(255, 33, 33, 33);

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <returns>Fluent Emoji Path</returns>
    private static string Path(FluentEmojiType type) =>
        $"{folder}.{Enum.GetName(typeof(FluentEmojiType), type) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <param name="contrast">Contrast Colour</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(FluentEmojiType type, Color? contrast = null) =>
        new((contrast == null ? AsStream(root, Path(type)) : 
        AsStream(root, Path(type), source, contrast)) ?? 
            new MemoryStream(), height, width);
}