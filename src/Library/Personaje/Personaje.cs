using System;
namespace Library;
using System;

public class Personaje
{
    public Personaje(string nombre, int vida, int daño, int defensa)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.Daño = daño;
        this.Defensa = defensa;
    }
    public string Nombre { get; set; }
    public double Vida { get; set; }
    public float Daño { get; set; }
    public double Defensa { get; set; }
    public bool Vivo()
    {
        return Vida > 0;
    }
    public void EquiparItem(Item item)
    {
        this.Daño += item.Daño;
    }
    
    public void Atacar(Personaje uno)
    {
        float var = (float)(uno.Vida - Math.Round((this.Daño)*(1-(uno.Defensa/500))));
        uno.Vida = var;
        
    }
}