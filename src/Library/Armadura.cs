namespace Library;

public class Armadura
{
    public Armadura( string nombre, int defensa )
    {
        this.Nombre = nombre;
        this.Defensa = defensa;
    }
    public string Nombre { get; set; }
    public int Defensa { get; set; }
    
/*     public void Equipar(Personaje personaje)
    {

    } */
}