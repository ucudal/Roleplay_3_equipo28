namespace Library;

public class Enemigo : Personaje
{
    public Enemigo(string nombre, int vida, int daño, int defensa, int vp) : base(nombre, vida, daño, defensa, vp)
    {

    }
    public int Vp { get; set; }

}