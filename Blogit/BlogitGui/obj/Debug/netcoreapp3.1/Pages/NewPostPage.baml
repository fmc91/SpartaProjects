   M S B A M L   `   `   `  ����D  @BlogitGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlogitGui	BlogitGui  5          BlogitGui.NewPostPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BlogitGui     5        N� Title$  New Post��5	       N� WindowTitle$ BlogIt - New Post��5
         BookshelfBackgroundBrush N� 
Background# [  5       N� ShowsNavigationUI$ False��5       � 	Resources 5        PageHeadingStyle �� 
TargetType �� Property  	TextColor �� Value  PostTitleTextBoxStyle  RoundedTextBoxStyle �� BasedOn��%�   &	       7  &	 �     7  �� 5   
   " ��6)   .�5      ��  � ��8   6+   �� 5       � ��$ 32(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   8   " ��6]   .�5      ��  � ��$ 14(�6)   5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5       $��60 �6   �� 5!      $��* �6   .+�5$   
      BlogitGui.MenuBar     BlogitGui.MenuBar
   HomeButtonClick$
 HomeButtonClick��5%         NewPostButtonClick$ NewPostButtonClick��5&         MyPostsButtonClick$ MyPostsButtonClick��5'         ProfileButtonClick$ ProfileButtonClick��5(         LogoutButtonClick$ LogoutButtonClick��5)      $��0��5$         Username 6%   �� *LoggedInUser+5)      � 5+   
   $��1��6   ��5-      �� 5.       �� Color$ Black��6"    �� Opacity$
 0.75Q�60   .+�51      �� .��53      � $	��400��6   $��Center=�6&   .+�54      ��   CardBackgroundBrush#��[ 6    �� CornerRadius$ 10��6O    �� Padding$ 15q�6a   ._�55      � 	 57      �� 58   "   $
��Auto �60   �� 59   "   $��10 �60   �� 5:   "   $
��Auto �60   �� 5;   "   $
��Auto �60   �� 5<   "   $��10 �60   �� 5=   "   $
��Auto �60   �� 5>   "   $
��Auto �60   �� 5?   "   $��15 �60   �� 5@   "   $
��Auto �60   .+�5C      �� #��[ 6(   $��0��6R   $��New Post��6_   �� 5E        TextBoxLabelStyle#��[ 6(   $��2��6S   $��Title:��6`   �� 5F      -   5         ��Name$ TitleBox��5F   &   #��[ 68   $��3��6g   ��5G   &   �� *Title+�� 5I      #��[ 6(   $��5��6S   $��Post:��6`   �� 5J      -   5        $ 
ContentBox��5J   &     NewPostTextBoxStyle#��[ 6:   $��6��6g   ��5K   &   �� *	Content+�� 5M      -   5          ButtonStyle#��[ 5M   %   $��8��6J   $	��120��6W   $
��Post��6c   5N   %   5P      5Q      5R      5T      5V      5X      5Y      