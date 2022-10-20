namespace Library;

public interface Armas
{
    public Armas(string nombre, int poder)
    {
        this.Nombre = nombre;
        this.Poder = poder;
    }
    private int Poder { get; set; }
    private string nombre { get; set; }

    public void Equipar(Personaje personaje)
    {

    }

}