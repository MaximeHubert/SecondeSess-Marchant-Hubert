﻿#pragma checksum "..\..\MainWindow - Copier.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "623CE2E58FFE4451D6844A1444D1E6D6E58FEC3DA64066BEBFF052F90FF03624"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ApplicWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ApplicWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridActor;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSuivant;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonPrecedent;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRecherche;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAnnuler;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textrecherche;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelNomActor;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageFilm;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listFilm;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listPersonnage;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCommentaire;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ApplicWPF;component/mainwindow%20-%20copier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow - Copier.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dataGridActor = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\MainWindow - Copier.xaml"
            this.dataGridActor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClickActor);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonSuivant = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\MainWindow - Copier.xaml"
            this.ButtonSuivant.Click += new System.Windows.RoutedEventHandler(this.PSuivante);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonPrecedent = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MainWindow - Copier.xaml"
            this.ButtonPrecedent.Click += new System.Windows.RoutedEventHandler(this.PPrecedent);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonRecherche = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow - Copier.xaml"
            this.ButtonRecherche.Click += new System.Windows.RoutedEventHandler(this.BRecherche);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonAnnuler = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\MainWindow - Copier.xaml"
            this.ButtonAnnuler.Click += new System.Windows.RoutedEventHandler(this.BAnnuler);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textrecherche = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.LabelNomActor = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.ImageFilm = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.listFilm = ((System.Windows.Controls.ListView)(target));
            
            #line 26 "..\..\MainWindow - Copier.xaml"
            this.listFilm.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClickFilm);
            
            #line default
            #line hidden
            return;
            case 10:
            this.listPersonnage = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.ButtonCommentaire = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\MainWindow - Copier.xaml"
            this.ButtonCommentaire.Click += new System.Windows.RoutedEventHandler(this.ClickCommentaire);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

