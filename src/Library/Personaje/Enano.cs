namespace Library;

public class Enano : Heroe
{
    public Enano(string nombre) : base(nombre, 200, 40, 50, 0, 200, 0)
    {

    }
    public void Borrachera()
    {
        this.Daño *= 2;
        this.Vida *= 0.4;
        this.Defensa*= 0.7;
    }


} 