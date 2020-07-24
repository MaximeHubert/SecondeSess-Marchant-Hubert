using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        private BLLManager manager = null;

        public void AddComment(int idcom, string avatar, string text, int rate)
        {
            manager = new BLLManager();
            manager.AddComment(idcom, avatar, text, rate);
        }

        public void AddFilm(Film film)
        {
            manager = new BLLManager();
            manager.AddFilm(film);
        }

        public List<Film> Recup5Film()
        {
            manager = new BLLManager();
            return manager.Recup5Film();
        }

        public FullActor RecupAllActor(long idall)
        {
            manager = new BLLManager();
            return manager.RecupAllActor(idall);
        }

        public List<Film> RecupFilmActor(long recherche)
        {
            manager = new BLLManager();
            return manager.RecupFilmActor(recherche);
        }

        public List<Film> RecupFilmActorName(string rechercheactor, int max)
        {
            manager = new BLLManager();
            return manager.RecupFilmActorName(rechercheactor, max);
        }

        public List<Character> RecupRoleFilmActor(long idactor, long idfilm)
        {
            manager = new BLLManager();
            return manager.RecupRoleFilmActor(idactor, idfilm);
        }

        public List<Film> RecuptopFilm()
        {
            manager = new BLLManager();
            return manager.RecuptopFilm();
        }




        /*
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
    }
}
