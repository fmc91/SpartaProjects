   M S B A M L   `   `   `  ����D  @BlogitGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlogitGui	BlogitGui  5          BlogitGui.MenuBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BlogitGui     5      -   5          >�Name$
  Root��5       � 	Resources 5         UsernameStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6&   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ SemiBold"�6+   �� 5       � ��
 �����6+   �� 5       � ��$ Center=�62   �� 5       � ��$ 2q�6'   5      5      .��5      �   MenuBarBackgroundBrush#��[ 6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5"   
   �� $	��0 6q�6   $��0��6   $,��&pack://application:,,,/images/logo.png��6-   �� 5$   
   -   5          MenuButtonStyle#��[ 5$      $��2��6:    � ToolTip$
 Home��6J   .��5&      �� $0��*pack://application:,,,/images/homeicon.png��6   $��30��6H   $��30��6S   5'      �� 5)   
   -   5        #��[ 5)      $��3��6:   $ New Post��6J   .��5+      �� $0��*pack://application:,,,/images/posticon.png��6   $��30��6H   $��30��6S   5,      �� 5.   
   -   5        #��[ 5.      $��4��6:   $ My Posts��6J   .��50      �� $3��-pack://application:,,,/images/mypostsicon.png��6   $��30��6K   $��30��6V   51      �� 53   
   #��[  6   $��5��6;   ��6K   ��  �� ElementName$
 Root�� �� Path$ Username��� 55   
   -   5        #��[ 55      $��6��6:   $ Profile��6J   .��57      �� $3��-pack://application:,,,/images/profileicon.png��6   $��30��6K   $��30��6V   58      �� 5:   
   -   5        #��[ 5:      $��7��6:   $ Log Out��6J   .��5<      �� $3��-pack://application:,,,/images/signouticon.png��6   $��30��6K   $��30��6V   5=      5?      5A      