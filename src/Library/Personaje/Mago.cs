namespace Library;
using System;
using System.Collections.Generic;

public class Mago : Personaje
{
    public Mago(string nombre) : base(nombre, 60, 100, 30)
    {
    }
    public void Tempestad()
    {
        this.Daño *= 2;
        this.Defensa *= 0.3;
        this.Vida *= 0.5;
    }
    public void EquiparMagia(ItemMagico item)
    {
        this.Daño += item.Daño;
        this.Defensa += item.Defensa;
    }
    
}