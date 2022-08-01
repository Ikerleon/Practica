using System;
public class ordenpremiun: decorador
{
    public ordenpremiun(ordenbase orden): base(orden)
    {
    }
    public override double CalculoTotalPrecio()
    {
        var precioOrdenPrecio= base.CalculoTotalPrecio();
        return precioOrdenPrecio*0.9;
    }
}