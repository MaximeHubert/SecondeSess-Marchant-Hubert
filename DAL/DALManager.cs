using DAL.Entities;
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

            if (!DBContext.film.Any(x => x.Id == Film.Id))
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

        public List<Film> RecupFilmActor(long recherche)
        {
            List<CharacterActor> characterActors = DBContext.characterActor.Where(ca => ca.Actor.Id == recherche).ToList();
            List<Film> ListFilm = new List<Film>();


            foreach (CharacterActor ca in characterActors)
            {
                ListFilm.Add(ca.Film);
            }
            return ListFilm;

        }

        public ICollection<Character> RecupRoleFilmActor(long idactor, long idfilm)
        {
            List<CharacterActor> characterActors = DBContext.characterActor.Where(ca => ca.Actor.Id == idactor && ca.Film.Id == idfilm).ToList();
            List<Character> ListCharacter = new List<Character>();

            foreach (CharacterActor ca in characterActors)
            {
                ListCharacter.Add(ca.Character);
            }
            return ListCharacter;
        }

        public ICollection<Film> RecupFilmActorName(string rechercheactor, int max)
        {
            List<CharacterActor> characterActors = DBContext.characterActor.Where(ca => ca.Actor.Surname.Contains( rechercheactor)).Take(max).ToList();
            List<Film> ListFilm = new List<Film>();


            foreach (CharacterActor ca in characterActors)
            {
                ListFilm.Add(ca.Film);
            }
            return ListFilm;
        }

        public ICollection<Film> RecuptopFilm()
        {
            return DBContext.film.OrderByDescending(f => f.VoteAverage).Take(10).ToList();
        }

        public Actor RecupMyActor(long idall)
        {
            Actor acteur = DBContext.actor.Where(a => a.Id == idall).First();
            return acteur;
        }


        public List<Film> Recup5Film()
        {
            return DBContext.film.Take(5).ToList();
        }

        public List<Character> RecupMyActorCharacter(long idall)
        {
            List<CharacterActor> characterActors = DBContext.characterActor.Where(ca => ca.Actor.Id == idall).ToList();
            List<Character> ListCharacter = new List<Character>();

            foreach (CharacterActor ca in characterActors)
            {
                ListCharacter.Add(ca.Character);
            }
            return ListCharacter;
        }

        public List<Comment> RecupMyActorComment(long idall)
        {
            List<Comment> liste = DBContext.comment.Where(c => c.IdActor == idall).ToList();
            return liste.OrderByDescending(c => c.Date).ToList();
        }

        public List<Film> RecupMyActorFilm(long idall)
        {
            List<CharacterActor> characterActors = DBContext.characterActor.Where(ca => ca.Actor.Id == idall).ToList();
            List<Film> ListFilm = new List<Film>();

            foreach (CharacterActor ca in characterActors)
            {
                if (!ListFilm.Any(x => x.Title == ca.Film.Title))
                {
                    ListFilm.Add(ca.Film);
                }            
            }
            return ListFilm;
        }

        public void AddComment(Comment newcomment)
        {
            if (!DBContext.comment.Any(c => c.Id == newcomment.Id))
            {
                DBContext.comment.Add(newcomment);
                DBContext.SaveChanges();
            }
        }

        public List<Actor> RecupActors(long id)
        {
            List<CharacterActor> characterActors = DBContext.characterActor.Where(ca => ca.Film.Id == id).ToList();
            List<Actor> ListActor = new List<Actor>();

            foreach(CharacterActor ca in characterActors)
            {
                ListActor.Add(ca.Actor);
            }
            return ListActor;
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

        public List<Actor> RecupActorByPage()
        {
            return DBContext.actor.OrderBy(a => a.Name).ThenBy(a => a.Surname).ToList(); 
        }

        public List<Actor> RecupActorByResearch(string recherche)
        {
            return DBContext.actor.Where(a => a.Surname.Contains(recherche)).OrderBy(a => a.Name).ThenBy(a => a.Surname).ToList(); ;
        }
    }
}
