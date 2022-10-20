namespace Library;

public interface Armaduras
{
    public Armaduras( string nombre, int poder )
    {
        this.Nombre = nombre;
        this.Poder = poder;
    }
    private string nombre;
    private int poder;
    
    public void Equipar(Personaje personaje)
    {

    }
}