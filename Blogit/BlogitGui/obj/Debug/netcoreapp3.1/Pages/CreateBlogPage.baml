   M S B A M L   `   `   `  ����D  @BlogitGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlogitGui	BlogitGui  5          BlogitGui.CreateBlogPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BlogitGui     5        N� Title$  CreateBlogPage��5	       N� WindowTitle$ BlogIt - Create Blog��5
       N� ShowsNavigationUI$ False��5         BookshelfBackgroundBrush N� 
Background# [  5       � 	Resources 5        PageHeadingStyle �� 
TargetType �� Property  	TextColor �� Value  MiscTextBoxStyle  RoundedTextBoxStyle �� BasedOn  AboutTextBoxStyle  NewPostTextBoxStyle��%  &	       7  &	     7  &	 �    7  �� 5   
   " ��6)   .�5      ��  � ��8   6+   �� 5       � ��$ 18(�6)   �� 5       � ��$
 Bold"�6+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � ��$
 Wrap=�6-   �� 5       � ��$ 0 0 0 10q�6'   5      �� 5   
   " ��6)   8   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 0 0 0 10q�6'   5      �� 5   
   " ��6*   8   .�5      ��  � ��$	 180��6'   5       5"      .��5$      � 	 � RowDefinitions	 5&   
   �� 5'      $��60 �6   �� 5(      $��* �6   .+�5+   
      BlogitGui.MenuBar     BlogitGui.MenuBar
   HomeButtonClick$
 HomeButtonClick��5,         NewPostButtonClick$ NewPostButtonClick��5-         MyPostsButtonClick$ MyPostsButtonClick��5.         ProfileButtonClick$ ProfileButtonClick��5/         LogoutButtonClick$ LogoutButtonClick��50      $��0��5+         Username 6%   �� *LoggedInUser+50      � 52   
   $��1��6   ��53      �� 54       �� Color$ Black��6"    �� Opacity$
 0.75Q�60   .+�57      �� $
��Auto=�6   $
��Auto=�6>   .��59      � .+�5;      ��   FormCardStyle#��[ 6   $	��400��6D   $��20q�6P   $��Center=�6\   ._�5=      �� .+�5?      �� #��[ 6(   ��6R   �� *	Message+�� 5A        TextBoxLabelStyle#��[ 6(   $��
Your name:��6S   �� 5C      #��[ 6&   ��6P   �� *UserActualName+�� 5E      #��[ 6(   $��Name of your blog:��6S   �� 5G      #��[ 6&   ��6P   �� *
BlogName+�� 5I      #��[ 6(   $��	Category:��6S   �� 5K      #��[ 6&   ��6P   �� *BlogCategory+�� 5M      #��[ 6(   $��About:��6S   �� 5O      #��[ 6&   ��6Q   �� *	BlogAbout+�� 5Q       �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5S   "   �� -   5         	 ButtonStyle#��[	 5S   )   $	��120��6N   $��5 15 5 0q�6Z   $��Confirm��6l   5T   )   �� 5U   "   -   5        #��[	 5U   )   $	��120��6N   $��5 15 5 0q�6Z   $
��Skip��6l   y�5V   )   �� *	CanSkip+ 
 BoolVisibility �� 	Converter# [
 5W   )   5Y      5[      5]      5_      5a      5c      5e      5g      