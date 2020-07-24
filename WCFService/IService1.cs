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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void AddFilm(Film film);

        [OperationContract]
        void AddComment(int idcom, string avatar, string text, int rate);

        [OperationContract]
        List<Film> Recup5Film();

        [OperationContract]
        List<Film> RecupFilmActor(long recherche);

        [OperationContract]
        List<Character> RecupRoleFilmActor(long idactor,long idfilm);

        [OperationContract]
        List<Film> RecupFilmActorName(string rechercheactor,int max);

        [OperationContract]
        List<Film> RecuptopFilm();

        [OperationContract]
        FullActor RecupAllActor(long idall);




        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
   /* [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }*/
}
