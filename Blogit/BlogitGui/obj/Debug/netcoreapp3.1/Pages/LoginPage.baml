   M S B A M L   `   `   `  ����D  @BlogitGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlogitGui	BlogitGui  5          BlogitGui.LoginPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BlogitGui     5        N� Title$  Login��5	       N� WindowTitle$ BlogIt - Login��5
         BookshelfBackgroundBrush N� 
Background# [  5       N� ShowsNavigationUI$ False��5       � 	Resources 5        MiscTextBlockStyle �� 
TargetType �� Property �� Value  ValidationTextBlockStyle  UsernameBoxStyle  RoundedTextBoxStyle �� BasedOn  PasswordBoxStyle  RoundedPasswordBoxStyle  LoginButtonStyle  ButtonStyle��%�  &	       &	 �     &	 �    7  &	 �    7  &	      7  �� 5   
   " ��6+   .�5      ��  � ��$ 14(�6)   �� 5       � �� �#15656e6+   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��61   .�5      ��  �@��TextAlignment$ Center=�6.   �� 5       � ��$ 14(�6)   �� 5       � ��$ SemiBold"�6+   �� 5       � ��
 �  ��6+   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6)   8   .�5      ��  � ��$ 14(�6)   5       �� 5"   
   " G�6)   8   .�5#      ��  � ��$ 14(�6)   5$      �� 5&   
   8   " ��6P   .�5'      ��  � ��$ 16(�6)   �� 5(       � ��$ SemiBold"�6+   5)      5+      .��5-      � ��5/   
   �� 50      	 �� Color$	 Black��6   
 �� Opacity$

 0.75Q�6,   .+�53   
   �� $
��Auto=�6   $
��Auto=�6:   .��55      � .+�57      �� $	��340��6   $��Center=�6%    	 FormCardStyle#��[	 6@   ._�58      �  � RowDefinitions 5:      �� 5;      $
��Auto �6,   �� 5<      $
��Auto �6,   �� 5=      $
��Auto �6,   �� 5>      $��10 �6,   �� 5?      $
��Auto �6,   �� 5@      $
��Auto �6,   �� 5A      $��10 �6,   �� 5B      $
��Auto �6,   �� 5C      $��10 �6,   �� 5D      $
��Auto �6,   �� 5E      $��50 �6,   �� 5F      $
��Auto �6,   �� 5G      $
��Auto �6,   .+�5J      �� $��0��6    $,��&pack://application:,,,/images/logo.png��6-   �� 5L       
 TextBoxLabelStyle#��[
 6$   $��1��6O   $��	Username:��6\   �� 5M      -   5         ��Name$ UsernameBox��5M   "   #��[ 67   $��2��6a   �� 5O      #��[
 6$   $��4��6O   $��	Password:��6\   G� 5Q      -   5         G�Name$ PasswordBox��5Q   &   #��[ 6;   $��5��6e   5R   &   �� 5T      #��[ 6$   $��7��6V   ��5U   $   �� *ValidationMessage+y�5V   $   �� *ValidationError+  BoolVisibility �� 	Converter# [ �� 5X      -   5        #��[ 5X   !   $��9��6K   $	��140��6X   $��Login��6d   5Y   !   �� 5[      #��[ 6$   $��11��6P   $��Center=�6^   $��14(�6{   $ ��Don't have an account yet?��5\       �� 5]      -   5        #��[ 5]   !   $��12��6F   $	��100��6T   $��Sign Up��6`   5^   !   5`      5a      5b      5d      5f      5h      