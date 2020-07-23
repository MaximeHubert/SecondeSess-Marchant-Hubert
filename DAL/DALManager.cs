﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALManager
    {

        private DALDBContext DBContext;
        private volatile Type dependency;


        public DALManager()
        {
            dependency = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            DBContext = DALDBContext.Instance;
        }

        public void AddFilm (Film Film, ICollection<Actor> Actors, ICollection<Character> Characters)
        {

            /*DBContext -> contient l'entierté des listes correspondant à la bdd*/
            /* ajouter le film s'il n'existe pas encore */
            /*parcourir la liste d'acteurs et de personnages pour les insérer un par un dans la bdd si ils n'existent pas (un prsonnage et un acteur en même temps)*/
            /* lier le film, l'acteur et le personnage au characterActor qui leur correspond de la bdd*/
            /* ne pas oublier : après un ou plusieurs ajouts, utiliser le DBContext.SaveChanges(); */
            if(DBContext.film.Any(x => x.Id == Film.Id))
            {

            }
            else
            {
                DBContext.film.Add(Film);

                int stop = Actors.Count;

                for (int i = 0; i < stop; i++)
                {

                    bool actor= AddActor(Actors.ElementAt(i));
                    bool character = AddCharacter(Characters.ElementAt(i));

                    CharacterActor liaison = new CharacterActor();

                    if(actor==true && character==true)
                    {
                        Film.CharacterActor.Add(liaison);
                        Actors.ElementAt(i).CharacterActor.Add(liaison);
                        Characters.ElementAt(i).CharacterActor.Add(liaison);
                    }
                    else
                    {
                        long verifActor = Actors.ElementAt(i).Id;
                        string verifcharacter = Characters.ElementAt(i).CharacterName;
                        Actor actorBDD = (DBContext.actor.Where(a => a.Id == verifActor)).First();
                        Character characterBDD = (DBContext.character.Where(c => c.CharacterName == verifcharacter)).First();
                        Film.CharacterActor.Add(liaison);
                        actorBDD.CharacterActor.Add(liaison);
                        characterBDD.CharacterActor.Add(liaison);
                    }
                    DBContext.SaveChanges();


                }
            }
        }

        private bool AddActor(Actor ajout)
        {
            if(!DBContext.actor.Any(x => x.Id == ajout.Id))
            {
                Actor retour = DBContext.actor.Add(ajout);
                DBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool AddCharacter (Character ajout)
        {
            if (!DBContext.character.Any(x => x.Id == ajout.Id))
            {
                Character retour = DBContext.character.Add(ajout);
                DBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
