using System;
public class ordenregular:ordenbase
{
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo de precio total de un pedido normal");
        return Productos.Sum(x=>x.precio)*0.0;    }
}