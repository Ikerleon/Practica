using System;
class Program{
    private static void Main(string[] args)
    {
        var Ordenregular= new ordenregular();
        Console.WriteLine(Ordenregular.CalculoTotalPrecio());
        Console.WriteLine();

        var Preorden= new preorden();
        Console.WriteLine(Preorden.CalculoTotalPrecio());
        Console.WriteLine();
        var ordenPremiun = new ordenpremiun(Preorden);
        Console.WriteLine(ordenPremiun.CalculoTotalPrecio());
        Console.WriteLine();
    }
}

