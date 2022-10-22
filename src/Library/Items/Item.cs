namespace Library;

public class Item
{
    public Item(string nombre, int daño, int defensa)
    {
        this.Nombre = nombre;
        this.Daño = daño;
        this.Defensa = defensa;
    }
    public int Defensa { get; }
    public int Daño { get; }

    public string Nombre { get; }

}