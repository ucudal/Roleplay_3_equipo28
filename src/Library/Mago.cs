namespace Library;
using System;
using System.Collections.Generic;

public class Mago : Personaje
{
    public Mago(string nombre, Arma arma, Armadura armdaura, Magic magic) : personaje (nombre, arma, armadura)
    {
        this.Magic = 10;
        this.vida = 100;
        this.Defensa: defensa;
        this.Nombre: nombre;
        this.Arma: arma;
    }
     private string Nombre { get; set; }
    public int Daño { get; set; }
    public int Vida { get; set; }
    public int Defensa { get; set; }
    public void Atacar( int daño, int vida, int defensa )

}
