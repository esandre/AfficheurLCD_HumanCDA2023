using System.Text;

namespace AfficheurLCD.Console;

internal class MultiplicationVerticale : INombre
{
    private readonly INombre _nombre;
    private readonly ushort _facteur;

    public MultiplicationVerticale(INombre nombre, ushort facteur)
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

        var firstLine = lines.First();
        var middleLine = lines.Skip(1).First();
        var lastLine = lines.Last();
        
        builder.AppendLine(firstLine);

        var firstHalfSpacerLine = middleLine.Replace('_', ' ');
        var lastHalfSpacerLine = lastLine.Replace('_', ' ');

        for (var i = 0; i < _facteur; i++)
            builder.AppendLine(firstHalfSpacerLine);

        builder.AppendLine(middleLine);

        for (var i = 0; i < _facteur; i++)
            builder.AppendLine(lastHalfSpacerLine);

        builder.AppendLine(lastLine);

        return builder.ToString();
    }
}