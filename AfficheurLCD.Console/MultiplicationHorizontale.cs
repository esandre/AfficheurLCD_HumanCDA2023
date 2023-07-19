using System.Text;

namespace AfficheurLCD.Console;

internal class MultiplicationHorizontale : INombre
{
    private readonly INombre _nombre;
    private readonly ushort _facteur;

    public MultiplicationHorizontale(INombre nombre, ushort facteur)
    {
        _nombre = nombre;
        _facteur = facteur;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var lines = _nombre.ToString()!
            .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var builder = new StringBuilder();

        foreach (var line in lines)
        {
            var firstChar = line.First();
            var middleChars = line.Skip(1).Reverse().Skip(1).Reverse().ToArray();
            var lastChar = line.Last();

            builder.Append(firstChar);
            for (var i = 0; i < _facteur; i++)
                builder.Append(middleChars);

            builder.Append(lastChar);
            builder.AppendLine();
        }

        return builder.ToString();
    }
}