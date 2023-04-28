namespace AdventOfCode.Helpers;

public static class StringHelpers
{
    public static string[] Lines(string text) => text.ReplaceLineEndings("\n").Split('\n');
    public static string[] Paragraphs(string text) => text.ReplaceLineEndings("\n").Split("\n\n");
}
