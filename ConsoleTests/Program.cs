
using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleTests
{
    class Program
    {
        private string file = @"C:\Users\maxim\OneDrive\Bureau\Annee3\Dotnet\movies_v2.txt";
        private StreamReader fichier = null;
        private BLLManager manager = null;
        static void Main(string[] args)
        {

            Program console = new Program();
            bool choix = false;
            while (choix == false)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("|                MENU               |");
                Console.WriteLine("-------------------------------------\n\n\n");
                Console.WriteLine("Que voulez vous faire ?\n");
                Console.WriteLine("(1) Importer des films");
                Console.WriteLine("(2) Faire des tests");
                Console.WriteLine("(3) Quitter\n");
                Console.WriteLine("Choix :");

                string reponse = Console.ReadLine();

                switch (reponse)
                {
                    case "1":
                        console.importFilm();
                        break;
                    case "2":
                        Console.Clear();
                        bool choixtest = false;
                        while (choixtest == false)
                        {
                            Console.Clear();
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("|             MENU TEST             |");
                            Console.WriteLine("-------------------------------------\n\n\n");
                            Console.WriteLine("Quel test voulez vous faire ?\n");
                            Console.WriteLine("(1) Afficher les 5 premiers film");
                            Console.WriteLine("(2) Afficher les films pour un acteur donné ( Id ) ");
                            Console.WriteLine("(3) Afficher les roles pour un acteur dans un film");
                            Console.WriteLine("(4) Afficher les films pour un acteur donné ( Nom ) ");
                            Console.WriteLine("(5) Afficher les 10 meilleurs film ");
                            Console.WriteLine("(6) Afficher tous les détails d'un acteur ");
                            Console.WriteLine("(7) Ajouter un commentaire ");
                            Console.WriteLine("(8) Quitter\n");
                            Console.WriteLine("Choix :");

                            string reponsetest = Console.ReadLine();
                            string rechercheactor;
                            string recherchefilm;
                            switch (reponsetest)
                            {
                                case "1":
                                    Console.Clear();
                                    console.afficher5film();
                                    Console.WriteLine("Tapez une touche pour continuer");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Ecrivez l'Id de l'acteur pour savoir ses films");
                                    rechercheactor = Console.ReadLine();
                                    long id = Convert.ToInt64(rechercheactor);
                                    console.GetListFilmsByIdActor(id);
                                    Console.WriteLine("Tapez une touche pour continuer");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Ecrivez l'Id de l'acteur");
                                    rechercheactor = Console.ReadLine();
                                    long idactor = Convert.ToInt64(rechercheactor);

                                    Console.WriteLine("Ecrivez l'Id du film");
                                    recherchefilm = Console.ReadLine();
                                    long idfilm = Convert.ToInt64(recherchefilm);
                                    console.GetListCharacterByIdActorAndIdFilm(idactor,idfilm);
                                    Console.WriteLine("Tapez une touche pour continuer");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "4":
                                    Console.Clear();
                                    Console.WriteLine("Ecrivez le nom en entier ou en partie d'un acteur pour savoir ses films");
                                    rechercheactor = Console.ReadLine();

                                    Console.WriteLine("Ecrivez le nombre max de film retournés");
                                    string maxfilm = Console.ReadLine();
                                    int max = Convert.ToInt32(maxfilm);
                                    console.FindListFilmByPartialActorName(rechercheactor,max);
                                    Console.WriteLine("Tapez une touche pour continuer");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("List des 10 meilleurs film \n\n");
                                    console.GetFavoriteFilms();
                                    Console.WriteLine("Tapez une touche pour continuer");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "6":
                                    Console.Clear();
                                    Console.WriteLine("Ecrivez l'Id de l'acteur pour savoir ses détails");
                                    rechercheactor = Console.ReadLine();
                                    long idall = Convert.ToInt64(rechercheactor);
                                    console.GetFullActorDetailsByIdActor(idall);
                                    Console.WriteLine("Tapez une touche pour continuer");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "7":
                                    Console.Clear();
                                    Console.WriteLine("Ecrivez l'Id de l'acteur pour votre commentaire");
                                    rechercheactor = Console.ReadLine();
                                    int idcom = Convert.ToInt32(rechercheactor);
                                    Console.WriteLine("Ecrivez votre nom d'avatar");
                                    string avatar = Console.ReadLine();
                                    Console.WriteLine("Ecrivez votre commentaire");
                                    string text = Console.ReadLine();
                                    Console.WriteLine("Ecrivez votre note [1-5]");
                                    string note = Console.ReadLine();
                                    int rate = Convert.ToInt32(note);
                                    console.InsertCommentOnActorId(idcom,avatar,text,rate);
                                    Console.WriteLine("Tapez une touche pour continuer");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "8":
                                    choixtest = true;
                                    Console.WriteLine("\n\nRetour au menu principal");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("\n\nVeuillez écrire un choix correct\n\n\n");
                                    break;

                            }


                        }



                            break;
                    case "3":
                        choix = true;
                        Console.WriteLine("\n\nL'application se fermera dans 3 secondes");
                        Thread.Sleep(3000);
                        break;
                    default:
                        Console.WriteLine("\n\nVeuillez écrire un choix correct\n\n\n");
                        break;
                }
            }
        }

        private void InsertCommentOnActorId(int idcom, string avatar, string text, int rate)
        {
            manager = new BLLManager();

            manager.AddComment(idcom,avatar,text, rate);
            Console.Clear();
            Console.WriteLine("Votre Commentaire a bien été encodé !");
            Console.WriteLine("\n\n\n");
        }

        private void GetFullActorDetailsByIdActor(long idall)
        {
            manager = new BLLManager();

            FullActor MyActor = manager.RecupAllActor(idall);
            Console.Clear();
            Console.WriteLine(" Id : " + MyActor.Id);
            Console.WriteLine(" Name : " + MyActor.Name);
            Console.WriteLine(" Surname: " + MyActor.Surname);
            Console.Write(" Characters : ");
            foreach (Character c in MyActor.characters)
            {
                Console.Write(c.CharacterName+ " | ");
            }

            Console.Write("\n Films : ");
            foreach (Film f in MyActor.Films)
            {
                Console.Write(f.Title + " | ");
            }

            Console.WriteLine(" \n Comments : ");
            foreach (Comment c in MyActor.Comment)
            {
                Console.WriteLine(" "+c.Name + " | Rate : "+ c.Rate + " | Date : " + c.Date + " | Avatar : " + c.Avatar);
            }
            Console.WriteLine("\n\n\n");
        }

        private void GetFavoriteFilms()
        {
            manager = new BLLManager();

            List<Film> ListFilm = manager.RecuptopFilm();

            foreach (Film f in ListFilm)
            {
                Console.WriteLine("Id :" + f.Id);
                Console.WriteLine("Title :" + f.Title);
                Console.WriteLine("VoteAverage :" + f.VoteAverage);
                Console.WriteLine("\n\n\n");

            }
        }

        private void FindListFilmByPartialActorName(string rechercheactor,int max)
        {
            manager = new BLLManager();

            List<Film> ListFilm = manager.RecupFilmActorName(rechercheactor,max);
            Console.Clear();
            Console.WriteLine("Actor nom : " + rechercheactor + "\n\n\n");

            int page=0;
            foreach (Film f in ListFilm)
            {
                if (page < 10)
                {
                    Console.WriteLine("Id :" + f.Id);
                    Console.WriteLine("Title :" + f.Title);
                    Console.WriteLine("ReleaseDate :" + f.ReleaseDate);
                    Console.WriteLine("VoteAverage :" + f.VoteAverage);
                    Console.WriteLine("RunTime :" + f.RunTime);
                    Console.WriteLine("PosterPath :" + f.PosterPath);
                    Console.WriteLine("\n\n\n");
                    page++;
                }
                else
                {
                    Console.WriteLine("Page Suivante -> [ENTER]");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Actor nom : " + rechercheactor + "\n\n\n");
                    page = 0;
                }
            }

        }

        private void GetListCharacterByIdActorAndIdFilm(long idactor, long idfilm)
        {
            manager = new BLLManager();

            List<Character> ListCharacter = manager.RecupRoleFilmActor(idactor,idfilm);
            Console.Clear();
            Console.WriteLine("Actor Id : " + idactor );
            Console.WriteLine("Film Id : " + idfilm + "\n\n\n");

            foreach (Character c in ListCharacter)
            {
                Console.WriteLine("Name :" + c.CharacterName);
            }
            Console.WriteLine("\n\n\n");
        }

        private void GetListFilmsByIdActor(long recherche)
        {
            manager = new BLLManager();

            List<Film> ListFilm = manager.RecupFilmActor(recherche);
            Console.Clear();
            Console.WriteLine("Actor Id : " + recherche+"\n\n\n");

            foreach (Film f in ListFilm)
            {
                Console.WriteLine("Id :" + f.Id);
                Console.WriteLine("Title :" + f.Title);
                Console.WriteLine("ReleaseDate :" + f.ReleaseDate);
                Console.WriteLine("VoteAverage :" + f.VoteAverage);
                Console.WriteLine("RunTime :" + f.RunTime);
                Console.WriteLine("PosterPath :" + f.PosterPath);
                Console.WriteLine("\n\n\n");
            }
        }

        private void afficher5film()
        {
            manager = new BLLManager();

            List<Film> List5Film = manager.Recup5Film();

            foreach (Film f in List5Film)
            {
                Console.WriteLine("Id :" + f.Id);
                Console.WriteLine("Title :" + f.Title);
                Console.WriteLine("ReleaseDate :" + f.ReleaseDate);
                Console.WriteLine("VoteAverage :" + f.VoteAverage);
                Console.WriteLine("RunTime :" + f.RunTime);
                Console.WriteLine("PosterPath :" + f.PosterPath);
                Console.Write("Actors  :  ");
                foreach (Actor a in f.Actor)
                {
                    Console.Write(a.Name + " " + a.Surname + " | ");
                }
                Console.WriteLine("\n\n\n");

            }

        }

        private void importFilm()
        {
            manager = new BLLManager();
            int i = 0;
            fichier = new StreamReader(file);

            while (i <1000)
            {
                string ligne = fichier.ReadLine();
                Film film = DecodeFilmline(ligne);
                if(film.Title.Length <=90)
                {
                    manager.AddFilm(film);
                }
                Console.WriteLine(i+" "+film.Title + " ");
                i++;

            }
            Console.WriteLine("Tapez une touche pour continuer");
            Console.ReadKey();
            Console.Clear();
        }


        private Film DecodeFilmline(string ligne)
        {
            Film f = new Film();
            Char[] delimiterChars = { '\u2023' }; 
            string[] filmdetailwords = ligne.Split(delimiterChars);
            delimiterChars[0] = '\u2016';

            // Initialisation des champs de base du film
            f.Id = Int32.Parse(filmdetailwords[0]);
            f.Title = filmdetailwords[1];
            f.ReleaseDate = filmdetailwords[3];
            f.VoteAverage = filmdetailwords[5];
            f.RunTime = Int32.Parse(filmdetailwords[7]);
            f.PosterPath = filmdetailwords[9];

            if (filmdetailwords.Length == 15)
            {
                string [] recherche = filmdetailwords[14].Split(delimiterChars);

                foreach (string s in recherche)
                {
                    if (s.Length > 0)
                    {
                        delimiterChars[0] = '\u2024';
                        string[] donnee = s.Split(delimiterChars);
                        delimiterChars[0] = '\u002f';
                        string[] Roles = donnee[2].Split(delimiterChars);

                        foreach ( string r in Roles)
                        {
                            Character text = new Character();
                            text.CharacterName = r;
                            f.Character.Add(text);

                            f.Actor.Add(DecodeActorline(s));
                        }


                    }
                }
            }
            return f;
        }

        private Actor DecodeActorline (string ligne)
        {
            Actor text = new Actor();
            Char[] delimiterChars = { '\u2024' };
            string[] actordetailwords = ligne.Split(delimiterChars);
            text.Id = Int32.Parse(actordetailwords[0]);
            delimiterChars[0] =' ';
            string[] listeNom = actordetailwords[1].Split(delimiterChars);
            text.Name = listeNom[0];

            try
            {
                text.Surname = listeNom[1];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                text.Surname = "";
            }
            return text;
        }

    }
}
