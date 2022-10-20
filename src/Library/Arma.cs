namespace Library;

public class Arma
{
    public Arma(string nombre, int daño)
    {
        this.Nombre = nombre;
        this.Daño = daño;
    }
    
    public int Daño { get; set; }

    public string Nombre { get; set; }

/*     public void Equipar(Personaje personaje)
    {

    } */

}