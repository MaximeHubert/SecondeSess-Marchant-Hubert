
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleTests
{
    class Program
    {
        private string file = @"C:\Users\maxim\OneDrive\Bureau\Annee3\Dotnet\movies_v2.txt";
        private StreamReader fichier = null;
        static void Main(string[] args)
        {

            Program console = new Program();
            bool choix = false;
            while (choix == false)
            {
                Console.WriteLine(" Voulez vous importer des films ?\n");
                Console.WriteLine("Si oui , tapez 1 \n");
                Console.WriteLine("Si non , tapez 2 \n");

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
                    default:
                        Console.WriteLine("Veuillez écrire un choix correcte\n\n\n");
                        break;
                }
            }
        }

        private void importFilm()
        {
            int i = 0;
            fichier = new StreamReader(file);

            while (i <1000)
            {
                string ligne = fichier.ReadLine();
                Film film = DecodeFilmline(ligne);
            }
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
                text.Surname = "";
            }
            return text;
        }

    }
}
