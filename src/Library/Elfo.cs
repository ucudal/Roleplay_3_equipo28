namespace Library;

public class Elfo : Personaje
{
    public Elfo(string nombre, Armas arma, Armaduras armadura, int vida, int daño, int defensa)
    {
        this.Nombre = nombre;
        this.Arma = arma;
        this.Armadura = armadura;
        this.Daño = daño;
        this.Vida = vida;
        this.Defensa = defensa;
    }
    private string Nombre { get; set; }
    public int Daño { get; set; }
    public int Vida { get; set; }
    public int Defensa { get; set; }
    public void Atacar( int daño, int vida, int defensa )
    {

    }
    public void Curar(int vida)
    {

    }
    public void Equipar(Armas arma)
    {

    }
    public Armas Arma { get; set; }
    public Armaduras Armadura { get; set; }