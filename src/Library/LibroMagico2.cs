 namespace Library;
 using System.Collections.Generic;
/*public class LibroDeMagiaBlanca
{
    public static List<string> libroMagico = new List<string>()
    {
        "Curar",
        "Bendecir",
        "Sanar",
    };
        public static void Curar()
    {
        int vida = 10;
    }
    public static void Bendecir()
    {
        int vida = 20;
    }
    public static void Sanar()
    {
        int vida = 30;
    }
} */
public class LibroMagico2 : ItemMagico
{
  public LibroMagico2() : base ("Libro de Magia", 0, 80)
  {
  } 
}