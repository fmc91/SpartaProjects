   M S B A M L   `   `   `  ����D  @BlogitGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlogitGui	BlogitGui  5          BlogitGui.EditPostPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BlogitGui     5        N� Title$  	Edit Post��5	       N� WindowTitle$ BlogIt - Edit Post��5
         BookshelfBackgroundBrush N� 
Background# [  5       N� ShowsNavigationUI$ False��5       � 	Resources 5        DeleteButtonStyle  ButtonStyle �� BasedOn �� 
TargetType �� Property �� Value	 �� 
StartPoint
 �� EndPoint � Color � Offset �� Triggers P� Property P� Value  PageHeadingStyle  	TextColor  PostTitleTextBoxStyle  RoundedTextBoxStyle��%�  &	       7  &	 �    7  &	 v    7  �� 5   
   8   " ��6Q   .�5      ��  � �� 5      �� 5      $		 0,0&�6*   $	
 0,1&�6;   .��5      � $ #d43b3b��6'   $ 0Q�67   � 5      $ #9c1a1a��6'   $ 1Q�67   5      5       5      P� 5       � ��$
 True��6/   . �5      ��  � �� 5      �� 5      $		 0,0&�62   $	
 0,1&�6C   .��5    "   � $ #fa6666��6/   $ 0Q�6?   � 5!   "   $ #cf2b2b��6/   $ 1Q�6?   5"      5$      5%      5(      �� 5*   
   " ��6)   .�5+      ��  � ��8   6+   �� 5,       � ��$ 32(�6)   �� 5-       � ��$
 Bold"�6+   5/      �� 51   
   8   " ��6]   .�52      ��  � ��$ 14(�6)   53      55      .��57      �  � RowDefinitions 59   
   �� 5:      $��60 �6   �� 5;      $��* �6   .+�5>   
      BlogitGui.MenuBar     BlogitGui.MenuBar   HomeButtonClick$ HomeButtonClick��5?         NewPostButtonClick$ NewPostButtonClick��5@         MyPostsButtonClick$ MyPostsButtonClick��5A         ProfileButtonClick$ ProfileButtonClick��5B         LogoutButtonClick$ LogoutButtonClick��5C      $��0��5>         Username 6%   �� *LoggedInUser+5C      � 5E   
   $��1��6   ��5G      �� 5H       �� Color$ Black��6"    �� Opacity$
 0.75Q�60   .+�5K      �� .��5M      � $	��400��6   $��Center=�6&   .+�5N      ��   CardBackgroundBrush#��[ 6    �� CornerRadius$ 10��6O    �� Padding$ 15q�6a   ._�5O      �  5Q      �� 5R   "   $
��Auto �60   �� 5S   "   $��10 �60   �� 5T   "   $
��Auto �60   �� 5U   "   $
��Auto �60   �� 5V   "   $��10 �60   �� 5W   "   $
��Auto �60   �� 5X   "   $
��Auto �60   �� 5Y   "   $��15 �60   �� 5Z   "   $
��Auto �60   .+�5]      �� #��[ 6(   $��0��6R   $��	Edit Post��6_   �� 5_        TextBoxLabelStyle#��[ 6(   $��2��6S   $��Title:��6`   �� 5`      #��[ 6&   $��3��6U   ��5a   &   �� *Title+ �� Mode$ TwoWay=��� 5c      #��[ 6(   $��5��6S   $��Post:��6`   �� 5d       	 NewPostTextBoxStyle#��[	 6&   $��6��6S   ��5e   &   �� *	Content+$ TwoWay=�� 5g      $��8��6#    � ColumnDefinitions 5h   "   �� 5i   &   $��* �67   �� 5j   &   $��* �67   �� 5k   &   $��* �67   .+�5n   "   �� -   5        #��[ 5n   )   $��0��6N   $��Save Changes��6^   5o   )   �� 5p   "   -   5        #��[ 5p   )   $��1��6N   $��Cancel��6^   5q   )   �� 5r   "   -   5        #��[ 5r   )   $��2��6T   $��Delete Post��6d   5s   )   5t      5v      5w      5x      5z      5|      5~      5      