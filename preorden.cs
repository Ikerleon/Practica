using System;
public class preorden:ordenbase
{
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo de precio total de un pedido pre oredenado");
        return Productos.Sum(x=>x.precio)*0.9;
    }
}