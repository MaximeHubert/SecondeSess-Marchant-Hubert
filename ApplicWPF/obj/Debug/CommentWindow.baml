   M S B A M L   `   `   `  ����D  @ApplicWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ApplicWPF	ApplicWPF  5   	       ApplicWPF.CommentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ApplicWPF     5   	     � Title$  
MainWindow��5   	   $	��606��6   $��1339.761��6)   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ listComment��5
      $	��427��6)   $��10,67,717,81q�66   $��18(�6L    �� View 5      �� 5      .P�5      �� $
��Date��6'    �� Width$	 100��67    �� DisplayMemberBinding 6C   �� *Date+�� 5      $��Content��6'   $	 250��6:    6F   �� *Name+�� 5      $
��Rate��6'   $	 150��67    6C   �� *Rate+�� 5      $��Avatar��6'   $ 80��69    6D   �� *Avatar+5      5      �� 5   
   -   5         ��Name$ LabelNew��5      $��New Comment��6"   $��Center=�68   $��918,88,225,411q�6U   $��25(�6m   $	��187��6{   $
��Bold"�6�   �� 5   
   -   5        $ LabelCommentaire��5      $��	Contenu :��6*   $��Center=�6>   $��613,321,263,178q�6[   $��25(�6t   $	��454��6�   �� 5   
   -   5         ��Name$ 
textavatar��5      $��722,169,388,352q�6&    �� TextWrapping$
 Wrap=�6?   $�� ��6S   �� 5   
   -   5        $ 	LabelCote��5      $��Cote :��6#   $��Center=�64   $��963,169,263,330q�6Q   $��25(�6j   $	��104��6x   �� 5   
   -   5         ��Name$ BoxCote��5      $��1048,176,16,364q�6%   	 �� Text$	 Aucun��6>   
 J� RenderTransformOrigin$
 0.5,0.5&�6K   .@�5      �� .��6   16   �� 5      .��6   26   �� 5      .��6   36   �� 5      .��6   46   �� 5      .��6   56   5      �� 5   
   -   5        $ LabelAvatar��5      $��	Avatar : ��6%   $��Center=�69   $��613,169,613,330q�6V   $��25(�6o   $	��104��6}   �� 5    
   -   5        $ textContenu��5       $��776,265,45,141q�6'   $
 Wrap=�6?   $�� ��6S   �� 5!   
   -	   5         ��Name$ 
ButtonSave��5!      $��Sauvegarder��6%   $��862,461,124,81q�6<   $��14(�6b   �� 5"   
   -
   5        $ ButtonClose��5"      $��Fermer��6&   $��187,512,921,29q�68   $��14(�6_   5#      5$      