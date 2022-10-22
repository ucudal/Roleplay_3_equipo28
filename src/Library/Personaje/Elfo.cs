namespace Library;

public class Elfo : Personaje
{
    public Elfo(string nombre) : base(nombre, 160, 55, 40)
    {

    }
    public void Curar(Personaje personaje)
    {
        personaje.Vida *= 1.3;
    }
}