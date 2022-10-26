namespace Library;

public class Elfo : Heroe
{
    public Elfo(string nombre) : base(nombre, 160, 55, 40, 0)
    {

    }
    public void Curar(Personaje personaje)
    {
        personaje.Vida *= 1.3;
    }
}