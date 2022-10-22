namespace Library
{
    public class ItemMagico 
    {
        public ItemMagico(string nombre,int daño, int defensa)
        {
            this.Nombre = nombre;
            
            this.Daño = daño;
            this.Defensa = defensa;
        }
        public string Nombre { get; set; }
        public int Daño { get; set; }
        public int Defensa { get; set; }
    
    }
}