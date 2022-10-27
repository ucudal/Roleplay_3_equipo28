namespace Library;

public class Heroe : Personaje
{
    public Heroe(string nombre, int vida, int daño, int defensa, int vp, int max_hp, int vp_difference) : base(nombre, vida, daño, defensa, vp)
    {
    }
    public int Max_hp { get; set; }
    public int Vp_difference { get; set; }
    public int Vp { get; set; }
    public void Sanar(int sanacion)
    {
        this.Vida += sanacion;
        if (this.Vida > this.Max_hp)
        {
            this.Vida = this.Max_hp;
        }
    }

}