using ApplicWPF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApplicWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int NumeroPage = 0;
        public static bool mode = false;
        public  long selectedactor = -1;
        Service1Client WPF = new Service1Client();
        public MainWindow()
        {
            InitializeComponent();
            int nombre = RecupActor();
            ButtonAnnuler.Visibility = Visibility.Hidden;

            if (NumeroPage == 0)
            {
                ButtonPrecedent.IsEnabled = false;
            }

            if (nombre < 10)
            {
                ButtonSuivant.IsEnabled = false;
            }

        }

        public int RecupActor()
        {
            List<ActorViewModel> ListActors = new List<ActorViewModel>();
            ICollection<DTO.Actor> ListActorDTO = WPF.RecupActorByPage(NumeroPage);

            foreach (DTO.Actor a in ListActorDTO)
            {
                ListActors.Add(new ActorViewModel(a.Id, a.Name, a.Surname));
            }

            dataGridActor.ItemsSource = ListActors.Select(a => new ActorViewModel() { Id = a.Id, Name = a.Name, Surname = a.Surname }).ToList();

            return ListActors.Count();

        }

        public int RecupActorRecherche()
        {
            List<ActorViewModel> ListActors = new List<ActorViewModel>();
            ICollection<DTO.Actor> ListActorDTO = WPF.RecupActorByResearch(NumeroPage, textrecherche.Text);

            foreach (DTO.Actor a in ListActorDTO)
            {
                ListActors.Add(new ActorViewModel(a.Id, a.Name, a.Surname));
            }

            dataGridActor.ItemsSource = ListActors.Select(a => new ActorViewModel() { Id = a.Id, Name = a.Name, Surname = a.Surname }).ToList();


            return ListActors.Count();

        }

        private void PSuivante(object sender, RoutedEventArgs e)
        {
            if (NumeroPage == 0)
            {
                ButtonPrecedent.IsEnabled = true;
            }
            int nombre;
            NumeroPage++;
            selectedactor = -1;

            if (mode == false)
            {
                nombre = RecupActor();
            }
            else
            {
                nombre = RecupActorRecherche();
            }


            if(nombre > 9)
            {
                ButtonSuivant.IsEnabled = true;
            }
            else
            {
                ButtonSuivant.IsEnabled = false;
            }

        }

        private void PPrecedent(object sender, RoutedEventArgs e)
        {
            NumeroPage--;
            int nombre;
            selectedactor = -1;

            if (mode == false)
            {
                nombre = RecupActor();
            }
            else
            {
                nombre = RecupActorRecherche();
            }

            if (NumeroPage == 0)
            {
                ButtonPrecedent.IsEnabled = false;
            }

            if(ButtonSuivant.IsEnabled== false)
            {
                ButtonSuivant.IsEnabled = true;
            }

        }

        private void BRecherche(object sender, RoutedEventArgs e)
        {
            if(!textrecherche.Text.Equals(""))
            {
                selectedactor = -1;
                NumeroPage = 0;
                mode = true;
                ButtonAnnuler.Visibility = Visibility.Visible;
                ButtonPrecedent.IsEnabled = false;
                int nombre = RecupActorRecherche();

                if (nombre > 9)
                {
                    ButtonSuivant.IsEnabled = true;
                }
                else
                {
                    ButtonSuivant.IsEnabled = false;
                }
            }
        }

        private void BAnnuler(object sender, RoutedEventArgs e)
        {
            mode = false;
            selectedactor = -1;
            ButtonAnnuler.Visibility = Visibility.Hidden;
            textrecherche.Text = "";
            RecupActor();
        }

        private void ClickActor(object sender, SelectionChangedEventArgs e)
        {
         

            ActorViewModel ActorSelect = (ActorViewModel)dataGridActor.SelectedItem;
            listFilm.Items.Clear();
            listPersonnage.Items.Clear();
            LabelNomActor.Content = "";
            var Poster = new BitmapImage();
            ImageFilm.Source = Poster;


            if (ActorSelect != null)
            {
                selectedactor = ActorSelect.Id;
                DTO.FullActor actor = WPF.RecupAllActor(ActorSelect.Id);

                Moyenne();

                /*List<DTO.Film> listfilmDTO = new List<DTO.Film>();
                List<DTO.Character> listcharacterDTO = new List<DTO.Character>();*/

               

                foreach (DTO.Film f in actor.Films)
                {
                    listFilm.Items.Add(f);
                }

            }
        }

        public void Moyenne ()
        {
            DTO.FullActor actor = WPF.RecupAllActor(selectedactor);
            float nombre = 0;
            float total = 0;

            foreach (DTO.Comment c in actor.Comment)
            {
                total = total + c.Rate;
                nombre++;
            }

            if (nombre == 0)
            {
                LabelNomActor.Content = actor.Name + " " + actor.Surname + " " + "(0)";
            }
            else
            {
                float moyenne = total / nombre;
                string moy = String.Format("{0:0.#}", moyenne);
                LabelNomActor.Content = actor.Name + " " + actor.Surname + " " + moy + " " + "(" + nombre.ToString() + ")";
            }
        }

        private void ClickFilm(object sender, SelectionChangedEventArgs e)
        {
            DTO.Film FilmSelect = (DTO.Film)listFilm.SelectedItem;
            listPersonnage.Items.Clear();

            if (FilmSelect != null && selectedactor != -1)
            {

                ICollection<DTO.Character> ListCharacter = WPF.RecupRoleFilmActor(selectedactor, FilmSelect.Id);

                foreach(DTO.Character c in ListCharacter)
                {
                    listPersonnage.Items.Add(c.CharacterName);
                }

                var Poster= new BitmapImage();
                Poster.BeginInit();
                Poster.UriSource = new Uri("https://image.tmdb.org/t/p/w185" + FilmSelect.PosterPath);
                Poster.EndInit();
                ImageFilm.Source = Poster;
                
            }
        }

        private void ClickCommentaire(object sender, RoutedEventArgs e)
        {
            
            if (selectedactor != -1)
            {
                CommentWindow PageComment = new CommentWindow(selectedactor,this);
                PageComment.Show();
                Moyenne();
            }



        }



    }
}
