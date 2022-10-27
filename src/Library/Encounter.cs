using System;
using System.Collections.Generic;
namespace Library;

public class Encounters
{
    
    public Encounters()
    {
    }
    public List<Enemigo> Enemigos = new List<Enemigo>{};
    public List<Heroe> Heroes = new List<Heroe>{};
    public void AddHero(Heroe heroe)
    {
        Heroes.Add(heroe);
    }
    public void AddEnemy(Enemigo enemigo)
    {
        Enemigos.Add(enemigo);
    }
    public void DoEncounter()
    {
        int n = 0;
        bool end = false;
        while ( !end ) 
        {
            foreach (Enemigo enemigo in Enemigos)
            {   
                Heroe heroe = (Heroe)Heroes[n];
                enemigo.Atacar(heroe);          //El enemigo ataca al heroe y si lo mata, lo remueve de la lista de heroes
                if (n == Heroes.Count-1)        //Cada enemigo ataca al heroe siguiente, si no hay vuelve al primero
                {
                    n=0;
                }
                else
                {
                    n+=1;
                }
                if (heroe.Vivo() == false)
                {
                    Heroes.Remove(heroe);
                }
                if (0 == Heroes.Count)          //Si la lista de heroes se vacia, se rompe el bucle
                {
                break;
                }
            }
            n=0;
            if (0 == Heroes.Count)              
            {   
                Enemigos.Clear();
                Heroes.Clear();
                break;
            }
            int cantenemies = Enemigos.Count;   
            foreach (Heroe heroe in Heroes)
            {
                if (Enemigos.Count != 0)                //Los heroes atacan si hay algo a lo que atacar
                {                                       //Cada heroe ataca a todos los
                for (int i=0;i < cantenemies; i++ )
                {
                    Enemigo enemigo = Enemigos[n];
                    heroe.Atacar(enemigo);  
                    if (enemigo.Vivo() == false)    //Si el enemigo muere, lo elimina de la lista y le da los vp al heroe
                    {
                        Enemigos.Remove(enemigo);
                        n-=1;
                        heroe.Vp += enemigo.Vp;
                    }
                    n+=1;                   
                }
                n=0;
                }
            int curacion=20*((heroe.Vp - heroe.Vp_difference) / 5); //El heroe se cura cada 5 vp ganados 20 de vida
            heroe.Sanar(curacion);
            if (curacion > 5)
            {
                heroe.Vp_difference = (heroe.Vp - heroe.Vp_difference) % 5; //Se guarda la diferencia para la siguiente iteracion
            }
            }

            if (0 == Enemigos.Count)    //Si no quedan enemigos, el encuentro se termina y se limpian las listas
            {
                foreach (Heroe heroe in Heroes)
                {
                    heroe.Vp_difference = heroe.Vp;     //
                }
                Enemigos.Clear();       
                Heroes.Clear();
                end = true;
            }
        }
        
        
    }
}