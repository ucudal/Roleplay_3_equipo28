namespace Library;

public class Elfo : Heroe
{
    public Elfo(string nombre) : base(nombre, 160, 55, 40, 0, 160, 0)
    {

    }
    public void Curar(Heroe personaje)
    {
        personaje.Vida *= 1.3;
        personaje.Sanar(personaje.Vida*0.3);
    }
}