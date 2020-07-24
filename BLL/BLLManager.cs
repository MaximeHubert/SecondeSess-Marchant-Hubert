using DAL;
using DAL.Entities;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DAL.Entities.Comment;

namespace BLL
{
    public class BLLManager
    {
        private DALManager Manager;

        public BLLManager()
        {
            Manager = new DALManager();
        }

        public void AddFilm (DTO.Film filmDTO)
        {
            DAL.Entities.Film filmDAL = new DAL.Entities.Film(filmDTO.Id, filmDTO.Title, filmDTO.ReleaseDate, filmDTO.VoteAverage, filmDTO.RunTime, filmDTO.PosterPath);

            ICollection<DAL.Entities.Actor> Actors = new List<DAL.Entities.Actor>();
            
            foreach(DTO.Actor a in filmDTO.Actor )
            {
                Actors.Add(new DAL.Entities.Actor(a.Id,a.Name,a.Surname));
            }

            ICollection<DAL.Entities.Character> Characters = new List<DAL.Entities.Character>();

            foreach (DTO.Character c in filmDTO.Character)
            {
                Characters.Add(new DAL.Entities.Character(c.CharacterName));
            }
            Manager.AddFilm(filmDAL, Actors, Characters);


        }

        public List<DTO.Film> Recup5Film()
        {
            List<DTO.Film> List5FilmDTO = new List<DTO.Film>();
            ICollection<DAL.Entities.Film> List5FilmDAL = Manager.Recup5Film();
            
           foreach(DAL.Entities.Film f in List5FilmDAL)
            {
                List<DAL.Entities.Actor> ListActorDAL = Manager.RecupActors(f.Id);
                List<DTO.Actor> ListActorDTO = new List<DTO.Actor>();

                foreach (DAL.Entities.Actor a in ListActorDAL)
                {
                    ListActorDTO.Add(new DTO.Actor(a.Id, a.Name, a.Surname));
                }
                DTO.Film FilmAdd = new DTO.Film(f.Id, f.Title, f.ReleaseDate, f.VoteAverage, f.RunTime, f.PosterPath);
                FilmAdd.Actor = ListActorDTO;
                List5FilmDTO.Add(FilmAdd);
            }
            return List5FilmDTO;
        }

        public List<DTO.Film> RecupFilmActor(long recherche)
        {
            List<DTO.Film> ListFilmDTO = new List<DTO.Film>();
            ICollection<DAL.Entities.Film> ListFilmDAL = Manager.RecupFilmActor(recherche);

            foreach(DAL.Entities.Film f in ListFilmDAL)
            {
                ListFilmDTO.Add(new DTO.Film(f.Id, f.Title, f.ReleaseDate, f.VoteAverage, f.RunTime, f.PosterPath));    
            }

            return ListFilmDTO;


        }

        public List<DTO.Character> RecupRoleFilmActor(long idactor, long idfilm)
        {
            List<DTO.Character> ListCharacterDTO = new List<DTO.Character>();
            ICollection<DAL.Entities.Character> ListCharacterDAL = Manager.RecupRoleFilmActor(idactor,idfilm);

            foreach (DAL.Entities.Character c in ListCharacterDAL)
            {
                ListCharacterDTO.Add(new DTO.Character(c.CharacterName));
            }

            return ListCharacterDTO;
        }

        public List<DTO.Film> RecupFilmActorName(string rechercheactor, int max)
        {
            List<DTO.Film> ListFilmDTO = new List<DTO.Film>();
            ICollection<DAL.Entities.Film> ListFilmDAL = Manager.RecupFilmActorName(rechercheactor,max);

            foreach (DAL.Entities.Film f in ListFilmDAL)
            {
                ListFilmDTO.Add(new DTO.Film(f.Id, f.Title, f.ReleaseDate, f.VoteAverage, f.RunTime, f.PosterPath));
            }

            return ListFilmDTO;
        }

        public List<DTO.Film> RecuptopFilm()
        {
            List<DTO.Film> ListFilmDTO = new List<DTO.Film>();
            ICollection<DAL.Entities.Film> ListFilmDAL = Manager.RecuptopFilm();

            foreach (DAL.Entities.Film f in ListFilmDAL)
            {
                ListFilmDTO.Add(new DTO.Film(f.Id, f.Title, f.ReleaseDate, f.VoteAverage, f.RunTime, f.PosterPath));
            }

            return ListFilmDTO;
        }

        public DTO.FullActor RecupAllActor(long idall)
        {
            
            List<DTO.Character> characterlist = new List<DTO.Character>();
            List<DTO.Comment> commentlist = new List<DTO.Comment>();
            List<DTO.Film> FilmList = new List<DTO.Film>();

            DAL.Entities.Actor actorDAL = Manager.RecupMyActor(idall);
            List<DAL.Entities.Character> characterDAL = Manager.RecupMyActorCharacter(idall);
            List<DAL.Entities.Film> FilmDAL = Manager.RecupMyActorFilm(idall);
            List<DAL.Entities.Comment> CommentDAL = Manager.RecupMyActorComment(idall);

            foreach(DAL.Entities.Character c in characterDAL)
            {
                characterlist.Add(new DTO.Character(c.CharacterName));
            }

            foreach (DAL.Entities.Film f in FilmDAL)
            {
                FilmList.Add(new DTO.Film(f.Title));
            }

            foreach(DAL.Entities.Comment c in CommentDAL)
            {
                commentlist.Add(new DTO.Comment(c.Name, (int)c.Rate, c.IdActor, c.Avatar,c.Date));
            }


            DTO.FullActor actorDTO = new DTO.FullActor(actorDAL.Id, actorDAL.Name, actorDAL.Surname,commentlist,FilmList,characterlist);

            return actorDTO;
        }

        public void AddComment(int idcom, string avatar, string text, int rate)
        {
            DTO.Comment newCommentDTO = new DTO.Comment(text, rate, idcom, avatar);
            DAL.Entities.Comment newcomment = new DAL.Entities.Comment(newCommentDTO.Id,newCommentDTO.Name,(cote)newCommentDTO.Rate,newCommentDTO.IdActor,newCommentDTO.Avatar);
            Manager.AddComment(newcomment);
        }
    }
}
