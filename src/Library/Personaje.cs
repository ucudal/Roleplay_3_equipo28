namespace Library;

public class Personaje
{
    private string Nombre { get; }

    Arma Arma { get; set; }

    Armaduras Armadura { get; set; }

    public int Daño { get; set; }
    public int Vida { get; set; }
    public int Defensa { get; set; }

    public bool Vivo()
    {
        return Vida > 0;
    }
}