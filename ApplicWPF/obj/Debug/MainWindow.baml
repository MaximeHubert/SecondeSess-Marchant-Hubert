   M S B A M L   `   `   `  ����D  @ApplicWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ApplicWPF	ApplicWPF  5   	       ApplicWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ApplicWPF     5   	     � Title$  
MainWindow��5   	   $	��606��6   $
��1478��6)    � 	Resources 5	        ApplicWPF.ConverterHour   ConverterHour��%   &	          5
   
   6   5      .��5      � $��	0,0,512,0q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridActor��5      $��28,69,654,230q�6+      AutoGenerateColumns .     
IsReadOnly . ��6B   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 132 63      
FontWeight$
 Bold"�6X   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� *Name+6X     5      $ Surname��6%   $	 132 66   $
 Bold"�6^   	 6B   �� *	Surname+6^   5      �� 5   
   -   5        
 ��Name$
 ButtonSuivant��5      $��Suivante��6(   $��194,373,654,169q�6<   6U   �� 5   
   -   5        $
 ButtonPrecedent��5      $��Précédent��6*   $��28,373,820,169q�6?   6W   �� 5   
   -   5        $
 ButtonRecherche��5      $��
Rechercher��6*   $��194,431,654,111q�6@   6Y   �� 5   
   -   5        $
 ButtonAnnuler��5      $��Annuler��6(   $��194,485,654,57q�6;   6S   �� 5   
   -   5         ��Name$ textrecherche��5      $��10,431,799,111q�6)    �� TextWrapping$
 Wrap=�6A   $�� ��6U   �� 5   
   -   5         ��Name$ LabelNomActor��5      $�� ��6'   $��Center=�62   $��347,10,-452,483q�6O   $��50(�6h   �� 5   
   -   5         ��Name$ 	ImageFilm��5      $	��274��6$   $	��246��62   $��347,116,362,185q�6R   ��6>   �� 6R   �� 5   
   -	   5         ��Name$ listFilm��5      $	��274��6&   $��624,116,-152,185q�63    �� View 5      �� 5      .P�5      �� $��Title��6'    �� Width$	 170��68    �� DisplayMemberBinding 6D   �� *Title+�� 5      $��ReleaseDate��6'   $	 100��6>    6J   �� *ReleaseDate+�� 5      $��VoteAverage��6'   $	 100��6>    6J   �� *VoteAverage+�� 5       $��RunTime��6'   $	 100��6:    6F   �� *	RunTime+ �� 	Converter# [  5!      5#      �� 5$   
   -
   5        $ listPersonnage��5$      $	��274��6,   $��1138,116,-452,185q�69    J� RenderTransformOrigin$ -0.134,0.477&�6T    5%      �� 5&      .P�5'      �� $��
Personnage��6'   $	 270��6<   5(      5*      �� 5+   
   -   5        $
 ButtonCommentaire��5+      $��Commentaire��6,   $��822,410,26,132q�6C   $	��110��6\   $��33��6�   5-      5.      