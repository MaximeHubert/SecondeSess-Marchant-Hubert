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
    public partial class CommentWindow : Window
    {
        public int id;
        Service1Client WPF = new Service1Client();
        private MainWindow mainWindow;

        public CommentWindow()
        {
            InitializeComponent();

        }

        public CommentWindow(long id)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(id);
            chargerComment(this.id);


        }

        public CommentWindow(long id, MainWindow mainWindow) : this(id)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            this.id = Convert.ToInt32(id);
            chargerComment(this.id);
        }

        private void BSave(object sender, RoutedEventArgs e)
        {
            if (!textavatar.Text.Equals("") && !textContenu.Text.Equals(""))
            {
                WPF.AddComment(this.id, textavatar.Text, textContenu.Text, Convert.ToInt32(BoxCote.Text));
                chargerComment(this.id);
                textavatar.Text = "";
                textContenu.Text = "";
                BoxCote.Text = "0";
                mainWindow.Moyenne();
            }

        }

        private void BClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void chargerComment(int id)
        {
            DTO.FullActor actor = WPF.RecupAllActor(id);
            listComment.Items.Clear();

            foreach (DTO.Comment c in actor.Comment)
            {
                string Tmp = "";

                switch (c.Rate)
                {
                    case 1:
                        Tmp = "★";
                        break;
                    case 2:
                        Tmp = "★★";
                        break;
                    case 3:
                        Tmp = "★★★";
                        break;
                    case 4:
                        Tmp = "★★★★";
                        break;
                    case 5:
                        Tmp = "★★★★★";
                        break;

                }
                listComment.Items.Add(new CommentViewModel(c.Name, Tmp, c.IdActor, c.Avatar,c.Date));
            }
        }
    }
}
