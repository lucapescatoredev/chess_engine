using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class Assert
{
    public static void That(
        bool condition,
        string message,
        [CallerFilePath] string file = "",
        [CallerLineNumber] int line = 0)
    {
        Debug.Assert(
            condition,
            $"{message} | {Path.GetFileName(file)}:{line}"
        );
    }
}