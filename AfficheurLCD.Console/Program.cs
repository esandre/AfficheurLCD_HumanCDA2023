using AfficheurLCD.Console;

const ushort coeffHorizontal = 8;
const ushort coeffVertical = 6;

Console.Write("> ");
Console.WriteLine(
    new MultiplicationVerticale(
        new MultiplicationHorizontale(
            Nombre.FromInt64(Convert.ToInt64(Console.ReadLine())),
        coeffHorizontal), 
    coeffVertical)
        .ToString()
);