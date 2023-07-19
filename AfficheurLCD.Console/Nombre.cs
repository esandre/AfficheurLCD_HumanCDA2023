namespace AfficheurLCD.Console;

internal class Nombre
{
    public static Nombre Un = new (
        "   ", 
        "  |", 
        "  |");

    public static Nombre Deux = new (
        " _ ", 
        " _|", 
        "|_ ");

    public static Nombre Trois = new(
        " _ ",
        " _|",
        " _|");

    public static Nombre Quatre = new(
        "   ",
        "|_|",
        "  |");

    public static Nombre Cinq = new(
        " _ ",
        "|_ ",
        " _|");

    public static Nombre Six = new(
        " _ ",
        "|_ ",
        "|_|");

    public static Nombre Sept = new(
        " _ ",
        "  |",
        "  |");

    public static Nombre Huit = new(
        " _ ",
        "|_|",
        "|_|");

    public static Nombre Neuf = new(
        " _ ",
        "|_|",
        " _|");

    public static Nombre Zéro = new(
        " _ ",
        "| |",
        "|_|");

    private readonly string _ligne1;
    private readonly string _ligne2;
    private readonly string _ligne3;

    private Nombre(string ligne1, string ligne2, string ligne3)
    {
        _ligne1 = ligne1;
        _ligne2 = ligne2;
        _ligne3 = ligne3;
    }

    /// <inheritdoc />
    public override string ToString() 
        => string.Join(Environment.NewLine, _ligne1, _ligne2, _ligne3);

    public static Nombre operator +(Nombre a, Nombre b)
        => new(
            a._ligne1 + ' ' + b._ligne1,
            a._ligne2 + ' ' + b._ligne2,
            a._ligne3 + ' ' + b._ligne3);

    public static Nombre FromInt64(long nombre)
        => nombre switch
           {
               0 => Zéro,
               1 => Un,
               2 => Deux,
               3 => Trois,
               4 => Quatre,
               5 => Cinq,
               6 => Six,
               7 => Sept,
               8 => Huit,
               9 => Neuf,
               _ => FromInt64(nombre / 10) + FromInt64(nombre % 10)
           };
}