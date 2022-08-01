using System;
public class decorador:ordenbase
{
    protected ordenbase orden;
    public decorador(ordenbase orden)
    {
        this.orden= orden;
    }
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo del precio total desde la clase decorador");
        return orden.CalculoTotalPrecio();
    }
}