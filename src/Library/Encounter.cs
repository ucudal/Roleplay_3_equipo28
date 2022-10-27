namespace Library;

public class Encounters 
{
    
    public void AddHero(Heroe heroe)
    {
        
    }
    public void AddEnemy(Enemigo enemy)
    {

    }
    public void DoEncounter(Heroe hero, Enemigo enemy)
    {
        
        while (hero.Vivo() & enemy.Vivo())
        {
            enemy.Atacar(hero);
            if (hero.Vivo())
            {
                hero.Atacar(enemy);
            }
            if (enemy.Vivo() == false)
            {
                hero.Vp += enemy.Vp;
            }
        }
        
    }
}