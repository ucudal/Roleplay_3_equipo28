namespace Library;

public class Armadura
{
    public Armadura(string nombre, int defensa)
    {
        this.Nombre = nombre;
        this.Defensa = defensa;
    }
    
    public int Defensa { get; set; }

    public string Nombre { get; set; }

}