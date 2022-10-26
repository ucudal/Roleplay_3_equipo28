namespace Library;

public class Heroe : Personaje
{
    public Heroe(string nombre, int vida, int daño, int defensa, int vp) : base(nombre, vida, daño, defensa)
    {

    }
    public int Vp { get; set; }

}