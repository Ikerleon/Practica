using System;
public abstract class ordenbase{
protected List<producto>Productos = new List<producto>
{
new producto{nombre="Telefono",precio=800},
new producto{nombre="Tablet",precio=1000},
new producto{nombre="PC Gamer",precio=1000}
};
public abstract double CalculoTotalPrecio();

}