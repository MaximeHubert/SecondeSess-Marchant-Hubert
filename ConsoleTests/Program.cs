
using BLL;
using DTO;
using System;
using System.Collections.Generic;
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
                Console.WriteLine("-------------------------------------\n");
                Console.WriteLine("|                MENU               |\n");
                Console.WriteLine("-------------------------------------\n\n\n");
                Console.WriteLine("Que voulez vous faire ?\n");
                Console.WriteLine("(1) Importer des films\n");
                Console.WriteLine("(2) Faire des tests\n");
                Console.WriteLine("(3) Quitter\n\n");
                Console.WriteLine("Choix :");

                string reponse = Console.ReadLine();

                switch (reponse)
                {
                    case "1":
                        console.importFilm();
                        choix = true;
                        break;
                    case "2":
                        choix = true;
                        break;
                    case "3":
                        choix = true;
                        Console.WriteLine("\n\nL'application se fermera dans 5 secondes\n");
                        Thread.Sleep(5000);
                        break;
                    default:
                        Console.WriteLine("\n\nVeuillez écrire un choix correct\n\n\n");
                        break;
                }
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
            Console.ReadKey();
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
