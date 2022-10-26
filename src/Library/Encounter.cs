namespace Library;

public class Encounters 
{
    public Encounters()
    {

    }

    public void DoEncounters(Heroe hero, Enemigo enemy)
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