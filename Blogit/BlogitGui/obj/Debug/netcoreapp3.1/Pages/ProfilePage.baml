   M S B A M L   `   `   `  ����D  @BlogitGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlogitGui	BlogitGui  5          BlogitGui.ProfilePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BlogitGui     5        N� Title$  ProfilePage��5	       N� WindowTitle$ BlogIt - My Profile��5
       N� ShowsNavigationUI$ False��5         BookshelfBackgroundBrush N� 
Background# [  5       � 	Resources 5        MiscTextBoxStyle �� 
TargetType  RoundedTextBoxStyle �� BasedOn �� Property �� Value  AboutTextBoxStyle  NewPostTextBoxStyle  PageHeadingStyle  	TextColor  InfoLabelStyle  	InfoStyle 	 ValidationMessageStyle��%�  &	       7  &	 w     7  &	 �     7  &	 �    7  &	 �    7  &		 9    �� 5   
   " ��6)   8   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 0 0 0 10q�6'   5      �� 5   
   " ��6*   8   .�5      ��  � ��$	 180��6'   �� 5       � ��$ 0 0 0 10q�6'   5      �� 5   
   " ��6)   .�5      ��  � ��8   6+   �� 5       � ��$ 24(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 0 0 0 10q�6'   5      �� 5!   
   " ��6'   .�5"      ��  � ��8   6+   �� 5#       � ��$ 14(�6)   �� 5$       � ��$ SemiBold"�6+   �� 5%       � ��$	 2 4q�6'   �� 5&       � ��$ Center=�62   5'      �� 5)   
   " ��6"   .�5*      ��  � ��8   6+   �� 5+       � ��$ 14(�6)   �� 5,       � ��$ 2q�6'   �� 5-       � ��$ Center=�62   5.      �� 50   
   " ��6/   .�51      ��  � ��
 �  ��6+   �� 52       � ��$ 12(�6)   �� 53       � ��$ SemiBold"�6+   �� 54       �@��TextAlignment$ Center=�6.   �� 55       � ��$ 2q�6'   �� 56       � ��$
 Wrap=�6-   57      59      .��5;      � 	 � RowDefinitions	 5=   
   �� 5>      $��60 �6   �� 5?      $��* �6   .+�5B   
      BlogitGui.MenuBar     BlogitGui.MenuBar
   HomeButtonClick$
 HomeButtonClick��5C         NewPostButtonClick$ NewPostButtonClick��5D         MyPostsButtonClick$ MyPostsButtonClick��5E         ProfileButtonClick$ ProfileButtonClick��5F         LogoutButtonClick$ LogoutButtonClick��5G      $��0��5B         Username 6%   �� *LoggedInUser+5G      � 5I   
   $��1��6   ��5K      �� 5L       �� Color$ Black��6"    �� Opacity$
 0.75Q�60   .+�5O      �� $
��Auto=�6   $
��Auto=�6>   .��5Q      � .+�5S      ��  
 FormCardStyle#��[
 6   $	��400��6D   $��20q�6P   $��Center=�6\   ._�5U      �� .+�5V      �� #��[ 6(   $��
My Profile��6R   �� 5X        TextBoxLabelStyle#��[ 6(   $��	Username:��6S   �� 5Y      #��[ 6(   ��6K   �� *LoggedInUser+�� 5[      #��[ 6(   $��Email Address:��6S   �� 5\      -   5         ��Name$ EmailBox��5\   &   #��[ 68   .��6b   ��5]   "   �� 5^   &    �� Path$ EmailAddress�6.    �� Mode$ TwoWay=�6B    �� UpdateSourceTrigger$ PropertyChanged=�6P    �� ValidationRules 5_   *      BlogitGui.EmailValidation  5`   .   5b   '   .��5c   0   5d      �� 5f      #��[	 6(   y�5g   (   ��  �� ElementName$ EmailBox��$ (Validation.HasError)�  BoolVisibility �� 	Converter# [ ��5i   (   �� $ EmailBox��$&  (Validation.Errors)/ErrorContent��� 5k      #��[ 6(   $��
Your name:��6S   �� 5l      #��[ 6&   ��5m   &   �� *Name+$ TwoWay=��� 5o      #��[ 6(   $��
Blog name:��6S   �� 5p      #��[ 6&   ��5q   &   �� *
BlogName+$ TwoWay=��� 5s      #��[ 6(   $��Blog category:��6S   �� 5t      #��[ 6&   ��5u   &   �� *BlogCategory+$ TwoWay=��� 5w      #��[ 6(   $��About:��6S   �� 5x      #��[ 6&   ��5y   &   �� *	BlogAbout+$ TwoWay=��� 5{       �� Orientation$ 
Horizontal=�6)   .+�5|   "   �� #��[ 6,   $��Active since:��6T   �� 5}   "   #��[ 6,   ��5~   ,   �� *BlogStats.ActiveSince+ �� StringFormat$ d�� �� ConverterCulture$ en-GB��5      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� #��[ 6,   $��Latest Post:��6T   �� 5�   "   #��[ 6,   ��5�   ,   �� *BlogStats.LatestPost+$ d��$ en-GB��5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� #��[ 6,   $��Number of posts:��6T   �� 5�   "   #��[ 6,   ��6O   �� *BlogStats.PostCount+5�      �� 5�      $ 
Horizontal=�6)   $��Center=�6B   $��0 10 0 0q�6_   .+�5�   "   �� -   5          ButtonStyle#��[ 5�   )   $��0 0 5 0q�6N   $	��120��6_   $��Save Changes��6k   5�   )   �� 5�   "   -   5        #��[ 5�   )   $��5 0 0 0q�6N   $	��120��6_   $��Cancel��6k   5�   )   5�      5�      5�      5�      5�      5�      5�      5�      