namespace Library;

public interface Personaje
{
    public class Personaje()
    {
        private string Nombre { get; }

        Armas Arma { get; set; }

        Armaduras Armadura { get; set; }

        public int Daño { get; set; }
        public int Vida { get; set; }
        public int Defensa { get; set; }

        bool Vivo()
        {

        }
    }
}
